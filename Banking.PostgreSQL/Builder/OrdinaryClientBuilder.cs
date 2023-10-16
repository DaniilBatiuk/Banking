using Banking.PostgreSQL.CQRS.Client.Commands.Create;
using Banking.PostgreSQL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Builder;

public class OrdinaryClientBuilder : ClientBuilder
{
    private readonly CreateClientCommand client = new CreateClientCommand();

    public override void BuildFirstName(string value)
    {
        client.FirstName = value;
    }

    public override void BuildLastName(string value)
    {
        client.LastName = value;
    }

    public override void BuildEmail(string value)
    {
        client.Email = value;
    }

    public override void BuildPasswordHash(string value)
    {
        client.PasswordHash = value;
    }

    public override CreateClientCommand GetResult()
    {
        return client;
    }
}
