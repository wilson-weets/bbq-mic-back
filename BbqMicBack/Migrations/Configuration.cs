namespace BbqMicBack.Migrations
{
    using BbqMicBack.DAL;
    using BbqMicBack.Models;
    using System;
    using System.Collections.Generic;
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
            context.Needs.RemoveRange(context.Needs);
            context.Needs.AddRange(new List<Product>()
            {
                new Product
                {
                    Name = "Saucisse de porc",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Saucisse de porc/boeuf",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Saucisse de porc/veau",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Saucisse de campagne",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Saucisse de poulet",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Saucisse de porc",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Filet de poulet",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Steak de boeuf",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Brochette mixte",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Brochette d'agneau",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Pilons de poulet",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Torsade",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Côtes d'agneau",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Poisson",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Boeuf (Autre)",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Porc (Autre)",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Poulet (Autre)",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Agneau (Autre)",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Autre",
                    Quantity = -1,
                    Unit = "",
                    Category = "Viandes"
                },
                new Product
                {
                    Name = "Salade de pâtes",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sides"
                },
                new Product
                {
                    Name = "Salade de patates",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sides"
                },
                new Product
                {
                    Name = "Salade de riz",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sides"
                },
                new Product
                {
                    Name = "Taboulé",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sides"
                },
                new Product
                {
                    Name = "Chips",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sides"
                },
                new Product
                {
                    Name = "Snacks",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sides"
                },
                new Product
                {
                    Name = "Assaisonnement",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sides"
                },
                new Product
                {
                    Name = "Autre",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sides"
                },
                new Product
                {
                    Name = "Salade de laitue",
                    Quantity = -1,
                    Unit = "",
                    Category = "Légumes"
                },
                new Product
                {
                    Name = "Salade de tomates",
                    Quantity = -1,
                    Unit = "",
                    Category = "Légumes"
                },
                new Product
                {
                    Name = "Salade mixte",
                    Quantity = -1,
                    Unit = "",
                    Category = "Légumes"
                },
                new Product
                {
                    Name = "Salade (Autre)",
                    Quantity = -1,
                    Unit = "",
                    Category = "Légumes"
                },
                new Product
                {
                    Name = "Autre",
                    Quantity = -1,
                    Unit = "",
                    Category = "Légumes"
                },
                new Product
                {
                    Name = "Ketchup",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Mayonnaise",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Barbecue",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Andalouse",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Samouraï",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Aioli",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Moutarde",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Brazil",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Giant",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Tomagrec",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Bicky",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Pickles",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Béarnaise",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Pita",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Curry",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Autre",
                    Quantity = -1,
                    Unit = "",
                    Category = "Sauces"
                },
                new Product
                {
                    Name = "Soda",
                    Quantity = -1,
                    Unit = "",
                    Category = "Boissons"
                },
                new Product
                {
                    Name = "Limonade",
                    Quantity = -1,
                    Unit = "",
                    Category = "Boissons"
                },
                new Product
                {
                    Name = "Orangeade",
                    Quantity = -1,
                    Unit = "",
                    Category = "Boissons"
                },
                new Product
                {
                    Name = "Eau",
                    Quantity = -1,
                    Unit = "",
                    Category = "Boissons"
                },
                new Product
                {
                    Name = "Bière",
                    Quantity = 90,
                    Unit = "Unités",
                    Category = "Boissons"
                },
                new Product
                {
                    Name = "Vin",
                    Quantity = -1,
                    Unit = "",
                    Category = "Boissons"
                },
                new Product
                {
                    Name = "Autre",
                    Quantity = -1,
                    Unit = "",
                    Category = "Boissons"
                },
                new Product
                {
                    Name = "Barbecue",
                    Quantity = 2,
                    Unit = "Unités",
                    Category = "Outils"
                },
                new Product
                {
                    Name = "Charbon",
                    Quantity = 6,
                    Unit = "kg",
                    Category = "Outils"
                },
                new Product
                {
                    Name = "Allume-feu",
                    Quantity = 2,
                    Unit = "Unités",
                    Category = "Outils"
                },
                new Product
                {
                    Name = "Feu",
                    Quantity = 1,
                    Unit = "Unités",
                    Category = "Outils"
                },
                new Product
                {
                    Name = "Plancha",
                    Quantity = 1,
                    Unit = "Unités",
                    Category = "Outils"
                },
                new Product
                {
                    Name = "Autre",
                    Quantity = -1,
                    Unit = "",
                    Category = "Outils"
                }
            }
            );
        }
    }
}
