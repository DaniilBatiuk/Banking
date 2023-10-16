using Banking.PostgreSQL.CQRS.Client.Commands.Create;
using Banking.PostgreSQL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Builder;

public abstract class ClientBuilder
{
    public abstract void BuildFirstName(string value);
    public abstract void BuildLastName(string value);
    public abstract void BuildEmail(string value);
    public abstract void BuildPasswordHash(string value);
    public abstract CreateClientCommand GetResult();
}
