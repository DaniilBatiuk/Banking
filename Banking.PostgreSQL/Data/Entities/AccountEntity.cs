using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Data.Entities;

public sealed class AccountEntity
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public decimal Balance { get; set; }
    public ClientEntity Client { get; set; }
    public ICollection<TransactionEntity> Transactions { get; set; }
}
