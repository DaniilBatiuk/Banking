using Banking.PostgreSQL.CQRS.Core.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.Transaction.Create;


public sealed record CreateTransactionCommand : ICommand
{
    public int AccountId { get; set; }
    public string TransactionType { get; set; }
    public decimal Amount { get; set; }

    public CreateTransactionCommand(int accountId, string transactionType, decimal amount)
    {
        AccountId = accountId;
        TransactionType = transactionType;
        Amount = amount;
    }
}
