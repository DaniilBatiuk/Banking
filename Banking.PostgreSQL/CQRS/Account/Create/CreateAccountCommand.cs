using Banking.PostgreSQL.CQRS.Core.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.Account.Create;

public sealed record CreateAccountCommand : ICommand
{
    public int ClientId { get; set; }
    public decimal Balance { get; set; }

    public CreateAccountCommand(int clientId, decimal balance)
    {
        ClientId = clientId;
        Balance = balance;
    }
}
