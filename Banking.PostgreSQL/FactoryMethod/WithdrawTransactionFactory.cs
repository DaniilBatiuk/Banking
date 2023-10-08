using Banking.PostgreSQL.CQRS.Transaction.Create;
using Banking.PostgreSQL.Data;
using Banking.PostgreSQL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.FactoryMethod;

public class WithdrawTransactionFactory : TransactionFactory
{
    public override CreateTransactionCommand CreateTransactionAsync(decimal amount, int accountId)
    {
        CreateTransactionCommand createTransactionCommand = new CreateTransactionCommand(
        accountId,
        "Withdraw",
        amount);

        return createTransactionCommand;
    }
}
