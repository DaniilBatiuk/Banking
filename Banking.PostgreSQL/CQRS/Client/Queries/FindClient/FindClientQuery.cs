using Banking.PostgreSQL.CQRS.Core.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.Client.Queries.FindClient;

public sealed record FindClientQuery : IQuery
{
    public string Email { get; }

    public FindClientQuery(string email)
    {
        Email = email;
    }
}
