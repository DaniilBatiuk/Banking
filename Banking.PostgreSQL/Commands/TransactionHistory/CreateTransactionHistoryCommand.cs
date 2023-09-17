using Banking.PostgreSQL.Commands.Transaction.Create;
using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Commands.TransactionHistory;

public sealed class CreateTransactionHistoryCommand : ICreateTransactionHistoryCommand
{
    private readonly BankingDbContext _context;

    public CreateTransactionHistoryCommand(BankingDbContext context)
    {
        _context = context;
    }

    public async Task Execute(CreateTransactionHistoryDto data)
    {
        TransactionHistoryEntity entity = new TransactionHistoryEntity
        {
            OperationDetails = data.OperationDetails,
            TransactionId = data.TransactionId,
            TimeCompletion = DateTime.UtcNow,
        };

        _context.TransactionHistory.Add(entity);
        await _context.SaveChangesAsync();
    }
}