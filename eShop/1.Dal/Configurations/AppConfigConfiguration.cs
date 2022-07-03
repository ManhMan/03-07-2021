using _1.Dal.Entiti;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Dal.Configurations
{
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");
            builder.HasKey(p => p.Key);
            builder.Property(p => p.Value).IsRequired(true); // not null
        }
    }
}
