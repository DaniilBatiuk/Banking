using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Data.Entities;

public sealed class TransactionHistoryEntity
{
    public int Id { get; set; }
    public int TransactionId { get; set; }
    public string OperationDetails { get; set; }
    public DateTime TimeCompletion { get; set; }
    public TransactionEntity Transaction { get; set; }
}
