using Banking.PostgreSQL.CQRS.Client.Commands.Create;
using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.Transaction.Create;

public sealed class CreateTransactionCommandHandler : ICreateTransactionCommandHandler
{
    private readonly BankingDbContext _context;

    public CreateTransactionCommandHandler(BankingDbContext context)
    {
        _context = context;
    }

    public async Task Handle(CreateTransactionCommand command)
    {

        TransactionEntity entity = new TransactionEntity
        {
            Amount = command.Amount,
            AccountId = command.AccountId,
            TransactionType = command.TransactionType,
            TimeCompletion = DateTime.UtcNow,
        };

        _context.Transaction.Add(entity);
        await _context.SaveChangesAsync();
    }
}
