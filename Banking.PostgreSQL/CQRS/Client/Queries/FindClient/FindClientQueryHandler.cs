using Banking.PostgreSQL.Data;
using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.Dtos.Client;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.CQRS.Client.Queries.FindClient;

public sealed class FindClientQueryHandler : IFindClientQueryHandler
{
    private readonly BankingDbContext _context;

    public FindClientQueryHandler(BankingDbContext context)
    {
        _context = context;
    }

    public async Task<ClientDto?> Handle(FindClientQuery query)
    {
        ClientEntity? entity = await _context.Clients.FirstOrDefaultAsync(p => p.Email == query.Email);

        return entity != null ? new ClientDto(entity.FirstName, entity.LastName, entity.Email, entity.PasswordHash) : default;
    }
}
