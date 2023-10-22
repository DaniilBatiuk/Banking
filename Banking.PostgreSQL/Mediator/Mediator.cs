using Banking.PostgreSQL.CQRS.Core.Command;
using Microsoft.Extensions.DependencyInjection;

namespace Banking.PostgreSQL.Mediator;

public sealed class Mediator : IMediator
{
    private readonly IServiceScopeFactory serviceScopeFactory;

    public Mediator(IServiceScopeFactory serviceScopeFactory)
    {
        this.serviceScopeFactory = serviceScopeFactory;
    }

    public async Task Send<TCommand>(TCommand command)
    {
        try
        {
            IServiceScope scope = serviceScopeFactory.CreateScope();
            IServiceProvider provider = scope.ServiceProvider;
            var handler = provider.GetRequiredService<ICommandHandler<TCommand>>();
            await handler.Handle(command);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Task<TResult> Send<TQuery, TResult>(TQuery query)
    {
        throw new NotImplementedException();
    }
}
