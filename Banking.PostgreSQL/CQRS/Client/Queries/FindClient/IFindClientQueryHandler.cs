using Banking.PostgreSQL.CQRS.Core.Query;
using Banking.PostgreSQL.Dtos.Client;

namespace Banking.PostgreSQL.CQRS.Client.Queries.FindClient;

public interface IFindClientQueryHandler : IQueryHandler<FindClientQuery, ClientDto?>
{

}
