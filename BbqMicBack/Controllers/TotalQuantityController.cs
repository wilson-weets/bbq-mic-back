using BbqMicBack.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BbqMicBack.Controllers
{
    public class TotalQuantityController : ApiController
    {
        BBQontext db = new BBQontext();

        public int GetTotalQuantity(int productId)
        {
            return db.Supplies.Where(s => s.Product.Id.Equals(productId)).Count();
        }
    }
}
