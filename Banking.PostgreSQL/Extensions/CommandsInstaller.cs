using Banking.PostgreSQL.Commands.Account.Create;
using Banking.PostgreSQL.Commands.Client.Create;
using Banking.PostgreSQL.Commands.Client.Delete;
using Banking.PostgreSQL.Commands.Transaction.Create;
using Banking.PostgreSQL.Commands.TransactionHistory.Create;
using Banking.PostgreSQL.CQRS.Account.Create;
using Banking.PostgreSQL.CQRS.Client.Commands.Create;
using Banking.PostgreSQL.CQRS.Client.Commands.Delete;
using Banking.PostgreSQL.CQRS.Client.Queries.FindClient;
using Banking.PostgreSQL.CQRS.Transaction.Create;
using Banking.PostgreSQL.CQRS.TransactionHistory.Create;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Extensions;

public static class CommandsInstaller
{
    public static IServiceCollection AddClientCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateClientCommandHandler, CreateClientCommandHandler>()
            .AddScoped<IDeleteClientCommandHandler, DeleteClientCommandHandler>();

        return services;
    }
    public static IServiceCollection AddClientQueries(this IServiceCollection services)
    {
        services
            .AddScoped<IFindClientQueryHandler, FindClientQueryHandler>();

        return services;
    }
    public static IServiceCollection AddAccountCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateAccountCommandHandler, CreateAccountCommandHandler>();
        return services;
    }

    public static IServiceCollection AddTransactionCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateTransactionCommandHandler, CreateTransactionCommandHandler>();

        return services;
    }

    public static IServiceCollection AddTransactionHistoryCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateTransactionHistoryCommandHandler, CreateTransactionHistoryCommandHandler>();

        return services;
    }
}
