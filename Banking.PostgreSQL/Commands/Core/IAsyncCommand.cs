using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Commands.Core;
public interface IAsyncCommand
{
    Task Execute();
}

public interface IAsyncCommand<TResult>
{
    Task<TResult> Execute();
}

public interface IAsyncCommand<in TData, TResult>
{
    Task<TResult> Execute(TData data);
}

