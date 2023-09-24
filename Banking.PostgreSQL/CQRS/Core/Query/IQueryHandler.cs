using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.Core.Query;

public interface IQueryHandler<in TQuery, TResult> where TQuery : IQuery
{
    Task<TResult> Handle(TQuery query);
}
