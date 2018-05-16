using BbqMicBack.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace BbqMicBack.Controllers
{
    [RoutePrefix("api/TotalQuantity")]
    public class TotalQuantityController : ApiController
    {
        BBQontext db = new BBQontext();

        [HttpGet]
        [Route("{productId}")]
        [ResponseType(typeof(int))]
        public IHttpActionResult GetTotalQuantity(int productId)
        {
            return Ok(db.Supplies
                .Where(s => s.Product.Id == productId)
                .Select(s => (int?)s.Quantity)
                .Sum() ?? 0);
        }
    }
}
