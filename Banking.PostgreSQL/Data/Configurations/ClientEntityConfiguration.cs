using Banking.PostgreSQL.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Data.Configurations;

public sealed class ClientEntityConfiguration : IEntityTypeConfiguration<ClientEntity>
{
    public void Configure(EntityTypeBuilder<ClientEntity> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.FirstName).IsRequired();
        builder.Property(e => e.LastName).IsRequired();
        builder.Property(e => e.Email).IsRequired();
        builder.Property(e => e.PasswordHash).IsRequired();
    }
}
