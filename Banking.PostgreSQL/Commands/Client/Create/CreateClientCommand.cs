using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Commands.Client.Create;

/*public sealed class CreateClientCommand : ICreateClientCommand
{
    private readonly BankingDbContext _context;

    public CreateClientCommand(BankingDbContext context)
    {
        _context = context;
    }

    public async Task Execute(CreateClientDto data)
    {
        ClientEntity entity = new ClientEntity
        {
            FirstName = data.FirstName,
            LastName = data.LastName,
            Email = data.Email,
            PasswordHash = data.PasswordHash,
        };

        _context.Clients.Add(entity);
        await _context.SaveChangesAsync();
    }

}*/
