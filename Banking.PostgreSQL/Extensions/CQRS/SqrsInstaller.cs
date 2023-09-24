using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Extensions.CQRS;

public static class SqrsInstaller
{
    public static IServiceCollection AddSQRS(this IServiceCollection services)
    {
        services
            .AddClientCommands()
            .AddClientQueries();

        return services;
    }
}
