using Banking.PostgreSQL.Commands.Client.Create;
using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Commands.Client.Delete;

/*public sealed class DeleteClientCommand : IDeleteClientCommand
{
    private readonly BankingDbContext _context;

    public DeleteClientCommand(BankingDbContext context)
    {
        _context = context;
    }

    public async Task Execute(DeleteClientDto data)
    {
        var client = await _context.Clients.FindAsync(data.Id);

        if (client != null)
        {
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }
    }

}*/
