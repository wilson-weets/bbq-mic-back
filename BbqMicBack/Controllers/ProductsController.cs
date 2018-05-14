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
    public class ProductsController : ApiController
    {
        private BBQontext db = new BBQontext();
        
        public IQueryable<Product> GetNeeds()
        {
            return db.Needs;
        }

        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Needs.Add(product);
            db.SaveChanges();

            return CreatedAtRoute("api/Products", new { id = product.Id }, product);
        }
        
        [ResponseType(typeof(bool))]
        public IHttpActionResult DeleteProduct(int id)
        {
            Product product = db.Needs.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            db.Needs.Remove(product);
            db.SaveChanges();

            product = db.Needs.Find(id);
            if(product != null)
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