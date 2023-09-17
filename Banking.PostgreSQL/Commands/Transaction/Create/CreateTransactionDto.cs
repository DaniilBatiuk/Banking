using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Commands.Transaction.Create;

public sealed record CreateTransactionDto
{
    public int AccountId { get; set; }
    public string TransactionType { get; set; }
    public decimal Amount { get; set; }

    public CreateTransactionDto(int accountId, string transactionType, decimal amount)
    {
        AccountId = accountId;
        TransactionType = transactionType;
        Amount = amount;
    }
}
