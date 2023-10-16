using Banking.PostgreSQL.CQRS.Core.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.Client.Commands.Create;

public sealed record CreateClientCommand : ICommand
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }

    public CreateClientCommand()
    {
        FirstName = "FirstName";
        LastName = "LastName";
        Email = "Email";
        PasswordHash = "PasswordHash";
    }
    public CreateClientCommand(string firstName, string lastName, string email, string passwordHash)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordHash = passwordHash;
    }

}
