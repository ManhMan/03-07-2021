using _1.Dal.Entiti;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Dal.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.Id);
            builder.Property(p=>p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(100);
            builder.Property(p => p.PhoneNumber).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Message).IsRequired();
        }
    }
}
