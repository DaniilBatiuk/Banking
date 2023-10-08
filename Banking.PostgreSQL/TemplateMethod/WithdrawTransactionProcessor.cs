using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.PostgreSQL.CQRS.Transaction.Create;

namespace Banking.PostgreSQL.TemplateMethod;

public class WithdrawTransactionProcessor : TransactionProcessor
{
    protected override void AddCommision(CreateTransactionCommand transaction)
    {
        transaction.Amount *= 1.01m;
    }
}
