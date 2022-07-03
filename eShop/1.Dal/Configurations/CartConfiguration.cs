using _1.Dal.Entiti;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Dal.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(p => p.Id);
            builder.Property(p=>p.Id).UseIdentityColumn();
            builder.HasOne(p => p.Product).WithMany(p => p.Carts).HasForeignKey(p => p.ProductId);
        }
    }
}
