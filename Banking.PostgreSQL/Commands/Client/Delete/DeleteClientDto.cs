using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Commands.Client.Delete;

public sealed record DeleteClientDto
{
    public int Id { get; set; }

    public DeleteClientDto(int id)
    {
        Id = id;
    }
}
