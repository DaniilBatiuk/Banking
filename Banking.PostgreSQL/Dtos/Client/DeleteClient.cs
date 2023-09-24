using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Dtos.Client;

public sealed record DeleteClient
{
    public int Id { get; set; }

    public DeleteClient(int id)
    {
        Id = id;
    }
}
