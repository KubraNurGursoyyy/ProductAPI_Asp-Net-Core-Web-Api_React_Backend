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
                new ProductEntities { ID = 1, Name = "Computer", Category = tech },
                new ProductEntities { ID = 2, Name = "Tablet", Category = tech },
                new ProductEntities { ID = 3, Name = "Fan", Category = accessories },
                new ProductEntities { ID = 4, Name = "Headphone", Category = accessories },
                new ProductEntities { ID = 5, Name = "Telephone", Category = mobile },
                new ProductEntities { ID = 6, Name = "Powerbank", Category = mobile },
                new ProductEntities { ID = 7, Name = "PS5", Category = gameConsoles },
                new ProductEntities { ID = 8, Name = "Tomb Raider", Category = gameConsoles }

            );
        }
    }
}
