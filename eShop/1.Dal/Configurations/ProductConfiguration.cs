using _1.Dal.Entiti;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Dal.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id); //khoa chinh prymarykey
            builder.Property(p => p.Price).IsRequired(true);
            builder.Property(p=>p.Stock).IsRequired(true);
            builder.Property(p=>p.OriPrice).IsRequired(true);
        }
    }
}
