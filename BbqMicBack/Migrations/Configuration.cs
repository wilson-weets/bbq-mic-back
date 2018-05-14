namespace BbqMicBack.Migrations
{
    using BbqMicBack.DAL;
    using BbqMicBack.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BbqMicBack.DAL.BBQontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BBQontext context)
        {
            context.Needs.AddOrUpdate(n => n.Name,
                new Product
                {
                    Name = ""
                }
            );
        }
    }
}
