using Banking.PostgreSQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.PostgreSQL.Extensions;

public static class BankingDataInstaller
{
    public static IServiceCollection AddBankingData(this IServiceCollection services, string connectionString)
    {
        services.AddDbContextPool<BankingDbContext>(options =>
            options
                .UseNpgsql(connectionString, builder => builder.MigrationsAssembly("Banking.PostgreSQL"))
            );

        return services;
    }
}
