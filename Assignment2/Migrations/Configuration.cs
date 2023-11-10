namespace Assignment2.Migrations
{
    using Assignment2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2.Data.Assignment2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment2.Data.Assignment2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var categories = new List<Category>
            {
                new Category{Name = "Jiping Zhao", ImageUrl = "/Content/Picture/Jiping Zhao.png"},
                new Category{Name = "Opera Excerpts", ImageUrl = "/Content/Picture/Opera Excerpts.png"},
                new Category{Name = "Zongsheng Li", ImageUrl = "/Content/Picture/Zongsheng Li.png"},
                new Category{Name = "The City of Prague Philharmonic Orchestra", ImageUrl = "/Content/Picture/Prague Philharmonic Orchestra.png"},
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{Name = "《The Curtain Rises》", Description = "China",Price = 1992,CategoryID=categories.Single(c=>c.Name == "Jiping Zhao").ID},
                new Product{Name = "《Renounce marriage》", Description = "China",Price = 1992,CategoryID=categories.Single(c=>c.Name == "Jiping Zhao").ID},
                new Product{Name = "《Winter night》", Description = "China",Price = 1990,CategoryID=categories.Single(c=>c.Name == "Jiping Zhao").ID},
                new Product{Name = "《Infant loss》", Description = "China",Price = 1990,CategoryID=categories.Single(c=>c.Name == "Jiping Zhao").ID},
                new Product{Name = "《All one's life》", Description = "China",Price = 1988,CategoryID=categories.Single(c=>c.Name == "Jiping Zhao").ID},
                new Product{Name = "《Change》", Description = "China",Price = 1988,CategoryID=categories.Single(c=>c.Name == "Jiping Zhao").ID},
                new Product{Name = "《To one's heart》", Description = "China",Price = 1988,CategoryID=categories.Single(c=>c.Name == "Jiping Zhao").ID},
                new Product{Name = "《Make one's debut》", Description = "China",Price = 1993,CategoryID=categories.Single(c=>c.Name == "Jiping Zhao").ID},
                new Product{Name = "《Pick up a baby》", Description = "China",Price = 1993,CategoryID=categories.Single(c=>c.Name == "Jiping Zhao").ID},
                new Product{Name = "《Drunken concubine》", Description = "Beijing Opera",Price = 1886,CategoryID=categories.Single(c=>c.Name == "Opera Excerpts").ID},
                new Product{Name = "《Peony Pavilion》", Description = "Drama",Price = 1617,CategoryID=categories.Single(c=>c.Name == "Opera Excerpts").ID},
                new Product{Name = "《Farewell my concubine》", Description = "Beijing Opera",Price = 1922,CategoryID=categories.Single(c=>c.Name == "Opera Excerpts").ID},
                new Product{Name = "《Make no sense of》", Description = "China",Price = 1993,CategoryID=categories.Single(c=>c.Name == "Zongsheng Li").ID},
                new Product{Name = "《When love is past》", Description = "China",Price = 2004,CategoryID=categories.Single(c=>c.Name == "Zongsheng Li").ID},
                new Product{Name = "《Bygone Love》", Description = "Czech Republic",Price = 2008,CategoryID=categories.Single(c=>c.Name == "The City of Prague Philharmonic Orchestra").ID},
                new Product{Name = "《Halt The Sunrise》", Description = "Czech Republic",Price = 2000,CategoryID=categories.Single(c=>c.Name == "The City of Prague Philharmonic Orchestra").ID},
                new Product{Name = "《Goat Hongs Song》", Description = "Czech Republic",Price = 2000,CategoryID=categories.Single(c=>c.Name == "The City of Prague Philharmonic Orchestra").ID},
                new Product{Name = "《Blue Sea Laughter》", Description = "Czech Republic",Price = 2001,CategoryID=categories.Single(c=>c.Name == "The City of Prague Philharmonic Orchestra").ID},
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}
