using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Builder;

public class ClientDirector
{
    private readonly ClientBuilder builder;

    public ClientDirector(ClientBuilder builder)
    {
        this.builder = builder;
    }

    public void Construct(string firstName, string lastName, string email,string passwordHash)
    {
        builder.BuildFirstName(firstName);
        builder.BuildLastName(lastName);
        builder.BuildEmail(email);
        builder.BuildPasswordHash(passwordHash);
    }
}
