using _1.Dal.Entiti;
using _1.Dal.Entiti.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Dal.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category"); 
            builder.HasKey(c => c.Id);
            builder.Property(p => p.Status).HasDefaultValue(Status.Active);
        }
    }
}
