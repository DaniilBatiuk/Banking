using Banking.PostgreSQL.Commands.Client.Create;
using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Commands.Account.Create;

public sealed class CreateAccountCommand : ICreateAccountCommand
{
    private readonly BankingDbContext _context;

    public CreateAccountCommand(BankingDbContext context)
    {
        _context = context;
    }

    public async Task Execute(CreateAccountDto data)
    {
        AccountEntity entity = new AccountEntity
        {
            Balance = data.Balance,
            ClientId = data.ClientId,
        };

        _context.Accounts.Add(entity);
        await _context.SaveChangesAsync();
    }

}
