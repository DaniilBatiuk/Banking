using Banking.PostgreSQL.CQRS.Client.Commands.Create;
using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.Client.Commands.Delete;

public sealed class DeleteClientCommandHandler : IDeleteClientCommandHandler
{
    private readonly BankingDbContext _context;

    public DeleteClientCommandHandler(BankingDbContext context)
    {
        _context = context;
    }

    public async Task Handle(DeleteClientCommand command)
    {

        var client = await _context.Clients.FindAsync(command.Id);

        if (client != null)
        {
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }
    }
}
