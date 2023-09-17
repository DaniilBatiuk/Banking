using Banking.PostgreSQL.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Data.Configurations;

public sealed class TransactionEntityConfiguration : IEntityTypeConfiguration<TransactionEntity>
{
    public void Configure(EntityTypeBuilder<TransactionEntity> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.TransactionType).IsRequired();
        builder.Property(e => e.Amount).IsRequired();
        builder.Property(e => e.TimeCompletion).IsRequired();
        builder.HasOne(e => e.Account)
               .WithMany(a => a.Transactions)
               .HasForeignKey(e => e.AccountId);
    }
}
