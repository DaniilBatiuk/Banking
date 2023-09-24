using Banking.PostgreSQL.CQRS.Core.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.TransactionHistory.Create;

public interface ICreateTransactionHistoryCommandHandler : ICommandHandler<CreateTransactionHistoryCommand>
{

}
