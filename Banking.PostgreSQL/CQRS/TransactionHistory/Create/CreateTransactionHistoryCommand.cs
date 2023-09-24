using Banking.PostgreSQL.CQRS.Core.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.TransactionHistory.Create;

public sealed record CreateTransactionHistoryCommand : ICommand
{

    public int TransactionId { get; set; }
    public string OperationDetails { get; set; }
    public CreateTransactionHistoryCommand(int transactionId, string operationDetails)
    {
        TransactionId = transactionId;
        OperationDetails = operationDetails;
    }
}
