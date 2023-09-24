using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Dtos.TransactionHistory;

public sealed record CreateTransalctionHistoryDto
{
    public int TransactionId { get; set; }
    public string OperationDetails { get; set; }
    public CreateTransalctionHistoryDto(int transactionId, string operationDetails)
    {
        TransactionId = transactionId;
        OperationDetails = operationDetails;
    }
}
