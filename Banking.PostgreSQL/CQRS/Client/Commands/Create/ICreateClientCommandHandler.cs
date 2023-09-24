using Banking.PostgreSQL.CQRS.Core.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.Client.Commands.Create;

public interface ICreateClientCommandHandler : ICommandHandler<CreateClientCommand>
{

}