﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbqMicBack.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public string Category { get; set; }
    }
}