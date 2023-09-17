using Banking.PostgreSQL.Commands.Account.Create;
using Banking.PostgreSQL.Commands.Client.Create;
using Banking.PostgreSQL.Commands.Client.Delete;
using Banking.PostgreSQL.Commands.Transaction.Create;
using Banking.PostgreSQL.Commands.TransactionHistory;
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
            .AddScoped<ICreateClientCommand, CreateClientCommand>()
            .AddScoped<IDeleteClientCommand, DeleteClientCommand>();

        return services;
    }

    public static IServiceCollection AddAccountCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateAccountCommand, CreateAccountCommand>();

        return services;
    }

    public static IServiceCollection AddTransactionCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateTransactionCommand, CreateTransactionCommand>();

        return services;
    }

    public static IServiceCollection AddTransactionHistoryCommands(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateTransactionHistoryCommand, CreateTransactionHistoryCommand>();

        return services;
    }
}
