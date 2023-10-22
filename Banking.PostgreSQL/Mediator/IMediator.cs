using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Mediator;

public interface ICommandMediator
{
    public Task Send<TCommand>(TCommand command);
}

public interface IQuery
{
    public Task<TResult> Send<TQuery, TResult>(TQuery query);
}


public interface IMediator : ICommandMediator, IQuery
{
}
