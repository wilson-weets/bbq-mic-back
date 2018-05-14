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
        public IHttpActionResult PutSupply(SupplyVM supply)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Supply supp = null;

            if (db.Supplies.Any())
                supp = db.Supplies.FirstOrDefault(s => s.SlackId.Equals(supply.SlackId) && s.Product.Id == supply.ProductId);

            if(supp != null)
            {
                supp.Quantity = supply.Quantity;
                db.SaveChanges();
                return Ok(supp);
            }

            return NotFound();
        }

        [ResponseType(typeof(Supply))]
        public IHttpActionResult PostSupply(SupplyVM supply)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Supply supp = null;

            if (db.Supplies.Any())
                supp = db.Supplies.FirstOrDefault(s => s.SlackId.Equals(supply.SlackId) && s.Product.Id == supply.ProductId);

            if (supp == null)
            {
                var prod = db.Needs.FirstOrDefault(n => n.Id == supply.ProductId);
                if(prod != null)
                {
                    supp = new Supply
                    {
                        SlackId = supply.SlackId,
                        Product = prod,
                        Quantity = supply.Quantity
                    };
                    var newSupp = db.Supplies.Add(supp);
                    db.SaveChanges();

                    return Ok(newSupp);
                }
                else
                {
                    return StatusCode(HttpStatusCode.NotFound);
                }
            }

            return StatusCode(HttpStatusCode.Found);
        }
        
        [ResponseType(typeof(bool))]
        public IHttpActionResult DeleteSupply(SupplyVM supply)
        {
            var supp = db.Supplies.FirstOrDefault(s => s.SlackId.Equals(supply.SlackId) && s.Product.Id == supply.ProductId);
            if (supp == null)
            {
                return NotFound();
            }

            db.Supplies.Remove(supp);
            db.SaveChanges();

            supp = db.Supplies.FirstOrDefault(s => s.SlackId.Equals(supply.SlackId) && s.Product.Id == supply.ProductId);
            if (supp != null)
                return Ok(false);

            return Ok(true);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}