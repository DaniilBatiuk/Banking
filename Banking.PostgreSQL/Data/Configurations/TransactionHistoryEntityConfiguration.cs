using Banking.PostgreSQL.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Data.Configurations;

public sealed class TransactionHistoryEntityConfiguration : IEntityTypeConfiguration<TransactionHistoryEntity>
{
    public void Configure(EntityTypeBuilder<TransactionHistoryEntity> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.OperationDetails).IsRequired();
        builder.Property(e => e.TimeCompletion).IsRequired();
        builder.HasOne(e => e.Transaction)
               .WithMany(t => t.TransactionHistory)
               .HasForeignKey(e => e.TransactionId);
    }
}
