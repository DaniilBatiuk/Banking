using Banking.PostgreSQL.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Data.Configurations;

public sealed class AccountEntityConfiguration : IEntityTypeConfiguration<AccountEntity>
{
    public void Configure(EntityTypeBuilder<AccountEntity> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Balance).IsRequired();
        builder.HasOne(e => e.Client)
               .WithMany(c => c.Accounts)
               .HasForeignKey(e => e.ClientId);
    }
}
