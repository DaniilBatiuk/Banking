using Banking.PostgreSQL.Commands.Client.Create;
using Banking.PostgreSQL.Commands.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Commands.Transaction.Create;

public interface ICreateTransactionCommand : INoResponseAsyncCommand<CreateTransactionDto>
{

}
