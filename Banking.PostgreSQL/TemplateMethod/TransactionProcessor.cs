using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.PostgreSQL.CQRS.Transaction.Create;

namespace Banking.PostgreSQL.TemplateMethod;

public abstract class TransactionProcessor
{
    public void ProcessTransaction(CreateTransactionCommand transaction)
    {
        ValidateTransaction(transaction);
        AddCommision(transaction);
    }

    protected abstract void AddCommision(CreateTransactionCommand transaction);

    private void ValidateTransaction(CreateTransactionCommand transaction)
    {
        if (transaction.Amount <= 0)
        {
            throw new ArgumentException("Сума транзакції повинна бути більше 0.");
        }
    }

}
