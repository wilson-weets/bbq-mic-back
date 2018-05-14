using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BbqMicBack.DAL;
using BbqMicBack.Models;

namespace BbqMicBack.Controllers
{
    public class SuppliesController : ApiController
    {
        private BBQontext db = new BBQontext();
        
        public List<Supply> GetSupplies(string slackId)
        {
            return db.Supplies.Where(s => s.SlackId.Equals(slackId)).ToList();
        }
        
        [ResponseType(typeof(Supply))]
        public IHttpActionResult PutSupply(Supply supply)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supp = db.Supplies.FirstOrDefault(s => s.SlackId.Equals(supply.SlackId) && s.Product.Id == supply.Product.Id);

            if(supp != null)
            {
                supp.Quantity = supply.Quantity;
                db.SaveChanges();
                return Ok(supp);
            }

            return NotFound();
        }

        [ResponseType(typeof(Supply))]
        public IHttpActionResult PostSupply(Supply supply)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supp = db.Supplies.FirstOrDefault(s => s.SlackId.Equals(supply.SlackId) && s.Product.Id == supply.Product.Id);

            if (supp == null)
            {
                var newSupp = db.Supplies.Add(supp);
                db.SaveChanges();

                return CreatedAtRoute("api/Supplies", new { supply = supp }, newSupp);
            }

            return StatusCode(HttpStatusCode.Found);
        }
        
        [ResponseType(typeof(Supply))]
        public IHttpActionResult DeleteSupply(Supply supply)
        {
            var supp = db.Supplies.FirstOrDefault(s => s.SlackId.Equals(supply.SlackId) && s.Product.Id == supply.Product.Id);
            if (supp == null)
            {
                return NotFound();
            }

            db.Supplies.Remove(supp);
            db.SaveChanges();

            return Ok(supp);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SupplyExists(int id)
        {
            return db.Supplies.Count(e => e.Id == id) > 0;
        }
    }
}