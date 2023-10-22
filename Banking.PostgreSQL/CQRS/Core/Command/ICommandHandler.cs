using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.Core.Command;

public interface ICommandHandler<TCommand>
{
    Task Handle(TCommand command);
}
