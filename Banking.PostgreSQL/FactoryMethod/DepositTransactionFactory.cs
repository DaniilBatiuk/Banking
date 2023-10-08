using Banking.PostgreSQL.CQRS.Transaction.Create;
using Banking.PostgreSQL.Data;
using Banking.PostgreSQL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.FactoryMethod;

public class DepositTransactionFactory : TransactionFactory
{

    public override CreateTransactionCommand CreateTransactionAsync(decimal amount, int accountId)
    {
        CreateTransactionCommand createTransactionCommand = new CreateTransactionCommand(
        accountId,
        "Deposit",
        amount);

        return createTransactionCommand;
    }
}

