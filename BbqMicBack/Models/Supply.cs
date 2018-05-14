using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbqMicBack.Models
{
    public class Supply
    {
        public int Id { get; set; }
        public string SlackId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}