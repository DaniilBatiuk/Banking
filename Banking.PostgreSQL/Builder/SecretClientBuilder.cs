using Banking.PostgreSQL.CQRS.Client.Commands.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Builder;

public class SecretClientBuilder : ClientBuilder
{
    private readonly CreateClientCommand client = new CreateClientCommand();

    public override void BuildFirstName(string value)
    {
        client.FirstName = "Secret";
    }

    public override void BuildLastName(string value)
    {
        client.LastName = "Secret";
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
