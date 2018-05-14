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

        // GET: api/Supplies/{slackId}
        public List<Supply> GetSupplies(string slackId)
        {
            return db.Supplies.Where(s => s.SlackId.Equals(slackId)).ToList();
        }

        // PUT: api/Supplies/5
        [ResponseType(typeof(Supply))]
        public IHttpActionResult PutSupply(string slackId, int productId, int quantity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supp = db.Supplies.FirstOrDefault(s => s.SlackId.Equals(slackId) && s.Product.Id == productId);

            if(supp != null)
            {
                supp.Quantity = quantity;
                db.SaveChanges();
                return Ok(supp);
            }

            return NotFound();
        }

        // POST: api/Supplies
        [ResponseType(typeof(Supply))]
        public IHttpActionResult PostSupply(string slackId, int productId, int quantity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supp = db.Supplies.FirstOrDefault(s => s.SlackId.Equals(slackId) && s.Product.Id == productId);

            if (supp == null)
            {
                db.Supplies.Add(supp);
                db.SaveChanges();

                var id = db.Supplies.FirstOrDefault(s => s.SlackId.Equals(slackId) && s.Product.Id == productId).Id;

                return CreatedAtRoute("api/Supplies", new { slackId = supp.SlackId, productId = supp.Product.Id, quantity = supp.Quantity }, supp);
            }

            return StatusCode(HttpStatusCode.Found);
        }

        // DELETE: api/Supplies/5
        [ResponseType(typeof(Supply))]
        public IHttpActionResult DeleteSupply(string slackId, int productId)
        {
            var supp = db.Supplies.FirstOrDefault(s => s.SlackId.Equals(slackId) && s.Product.Id == productId);
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