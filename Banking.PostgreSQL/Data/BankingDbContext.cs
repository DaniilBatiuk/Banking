using Banking.PostgreSQL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Data;

public sealed class BankingDbContext : DbContext
{
    public DbSet<AccountEntity> Accounts { get; init; }
    public DbSet<ClientEntity> Clients { get; init; }
    public DbSet<TransactionEntity> Transaction { get; init; }
    public DbSet<TransactionHistoryEntity> TransactionHistory { get; init; }

    public BankingDbContext(DbContextOptions<BankingDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
