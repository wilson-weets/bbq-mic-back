using BbqMicBack.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BbqMicBack.DAL
{
    public class BBQontext : DbContext
    {
        public BBQontext() : base()
        {

        }

        public BBQontext(string connectionString) : base(connectionString)
        {

        }

        public DbSet<Product> Needs { get; set; }
        public DbSet<Supply> Supplies { get; set; }
    }
}