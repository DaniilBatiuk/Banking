using Banking.PostgreSQL.CQRS.Client.Commands.Create;
using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.Account.Create;

public sealed class CreateAccountCommandHandler : ICreateAccountCommandHandler
{
    private readonly BankingDbContext _context;

    public CreateAccountCommandHandler(BankingDbContext context)
    {
        _context = context;
    }

    public async Task Handle(CreateAccountCommand command)
    {

        AccountEntity entity = new AccountEntity
        {
            Balance = command.Balance,
            ClientId = command.ClientId,
        };

        _context.Accounts.Add(entity);
        await _context.SaveChangesAsync();
    }
}
