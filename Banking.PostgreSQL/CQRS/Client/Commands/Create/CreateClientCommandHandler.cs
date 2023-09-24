using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Data;

namespace Banking.PostgreSQL.CQRS.Client.Commands.Create;

public sealed class CreateClientCommandHandler : ICreateClientCommandHandler
{
    private readonly BankingDbContext _context;

    public CreateClientCommandHandler(BankingDbContext context)
    {
        _context = context;
    }

    public async Task Handle(CreateClientCommand command)
    {

        ClientEntity entity = new ClientEntity
        {
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            PasswordHash = command.PasswordHash,
        };

        _context.Clients.Add(entity);

        await _context.SaveChangesAsync();
    }
}
