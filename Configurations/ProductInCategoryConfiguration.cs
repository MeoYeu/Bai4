using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Entyties;

namespace WebApplication3.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        

        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(t => new { t.CategoryId, t.ProductId });
            builder.HasOne(t => t.Product).WithMany(t => t.ProductInCategories).HasForeignKey(t=>t.ProductId);
            builder.HasOne(t => t.Category).WithMany(t => t.ProductInCategories).HasForeignKey(t => t.CategoryId);


        }
    }
}
