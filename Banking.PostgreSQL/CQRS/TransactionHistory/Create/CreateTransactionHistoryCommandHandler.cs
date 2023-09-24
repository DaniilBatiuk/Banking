using Banking.PostgreSQL.CQRS.Client.Commands.Create;
using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.TransactionHistory.Create;


public sealed class CreateTransactionHistoryCommandHandler : ICreateTransactionHistoryCommandHandler
{
    private readonly BankingDbContext _context;

    public CreateTransactionHistoryCommandHandler(BankingDbContext context)
    {
        _context = context;
    }

    public async Task Handle(CreateTransactionHistoryCommand command)
    {

        TransactionHistoryEntity entity = new TransactionHistoryEntity
        {
            OperationDetails = command.OperationDetails,
            TransactionId = command.TransactionId,
            TimeCompletion = DateTime.UtcNow,
        };

        _context.TransactionHistory.Add(entity);
        await _context.SaveChangesAsync();
    }
}


