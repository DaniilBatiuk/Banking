using Banking.PostgreSQL.CQRS.Transaction.Create;
using Banking.PostgreSQL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.FactoryMethod;

public abstract class TransactionFactory
{
    public abstract CreateTransactionCommand CreateTransactionAsync(decimal amount, int accountId);
}
