using Banking.PostgreSQL.CQRS.Transaction.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.ChainOfResponsibility;

public abstract class Approver
{
    protected Approver? Successor;

    public void SetSuccessor(Approver successor)
    {
        Successor = successor;
    }
    public abstract string ProcessTransaction(CreateTransactionCommand createTransalctionDto);
}
