using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData
{
    internal class Seeds
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            CategoryEntities tech = new CategoryEntities { ID = 1, Name = "Tech" };
            CategoryEntities accessories = new CategoryEntities { ID = 2, Name = "Accessories" };
            CategoryEntities mobile = new CategoryEntities { ID = 3, Name = "Mobile" };
            CategoryEntities gameConsoles = new CategoryEntities { ID = 4, Name = "Game & Consoles" };

            modelBuilder.Entity<CategoryEntities>().HasData(
                tech, accessories, mobile, gameConsoles
            );

            
            modelBuilder.Entity<ProductEntities>().HasData(
                new ProductEntities { ID = 1, Name = "Computer", Price = 999.00m, CategoryID = tech.ID },
                new ProductEntities { ID = 2, Name = "Tablet", Price = 442.00m, CategoryID = tech.ID },
                new ProductEntities { ID = 3, Name = "Fan", Price = 29.94m, CategoryID = accessories.ID },
                new ProductEntities { ID = 4, Name = "Headphone", Price = 99.45m, CategoryID = accessories.ID },
                new ProductEntities { ID = 5, Name = "Telephone", Price = 199.19m, CategoryID = mobile.ID },
                new ProductEntities { ID = 6, Name = "Powerbank", Price = 49.86m, CategoryID = mobile.ID },
                new ProductEntities { ID = 7, Name = "PS5", Price = 499.45m, CategoryID = gameConsoles.ID },
                new ProductEntities { ID = 8, Name = "Tomb Raider", Price = 59.12m, CategoryID = gameConsoles.ID }
                );
        }
    }
}
