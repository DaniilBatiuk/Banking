using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Data.Entities;

public sealed class TransactionEntity
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public string TransactionType { get; set; }
    public decimal Amount { get; set; }
    public DateTime TimeCompletion { get; set; }
    public AccountEntity Account { get; set; }
    public ICollection<TransactionHistoryEntity> TransactionHistory { get; set; }
}
