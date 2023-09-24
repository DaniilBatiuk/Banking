using Banking.PostgreSQL.Commands.Client.Create;
using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Commands.Transaction.Create;

/*public sealed class CreateTransactionCommand : ICreateTransactionCommand
{
    private readonly BankingDbContext _context;

    public CreateTransactionCommand(BankingDbContext context)
    {
        _context = context;
    }

    public async Task Execute(CreateTransactionDto data)
    {
        TransactionEntity entity = new TransactionEntity
        {
            Amount = data.Amount,
            AccountId = data.AccountId,
            TransactionType = data.TransactionType,
            TimeCompletion = DateTime.UtcNow,
        };

        _context.Transaction.Add(entity);
        await _context.SaveChangesAsync();
    }
}*/

