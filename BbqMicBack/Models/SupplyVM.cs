using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbqMicBack.Models
{
    public class SupplyVM
    {
        public string SlackId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}