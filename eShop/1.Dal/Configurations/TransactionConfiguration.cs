using _1.Dal.Entiti;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Dal.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
