using Banking.PostgreSQL.CQRS.Transaction.Create;
using Banking.PostgreSQL.Dtos.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.ChainOfResponsibility;

public sealed class Manager : Approver
{
    public override string ProcessTransaction(CreateTransactionCommand createTransalctionDto)
    {
        if (createTransalctionDto.Amount < 50000)
        {
            return $"Approved by {GetType().Name}. Amount transaction {createTransalctionDto.Amount}";
        }
        else
        {
            return Successor?.ProcessTransaction(createTransalctionDto) ?? "There is no approver for the next lvl";
        }
    }
}
