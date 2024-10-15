using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    internal class CategoryConfigurations : IEntityTypeConfiguration<CategoryEntities>
    {
        public void Configure(EntityTypeBuilder<CategoryEntities> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50); 

        }
    }
}
