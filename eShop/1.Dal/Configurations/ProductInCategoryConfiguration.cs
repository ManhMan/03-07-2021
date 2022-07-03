using _1.Dal.Entiti;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Dal.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(p => new { p.CategoryId, p.ProductId });
            builder.ToTable("ProductInCategorys");
            builder.HasOne(p => p.Product).WithMany(p => p.ProductInCategories).HasForeignKey(p => p.ProductId);
            builder.HasOne(p => p.Category).WithMany(p => p.ProductInCategories).HasForeignKey(p => p.CategoryId);
        }
    }
}
