using Banking.API.RestModels.Client;
using Banking.API.RestModels.Validators.Client;
using FluentValidation;

namespace Banking.API.RestModels.Validators;

public static class ValidatorsInstaller
{
    public static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services
            .AddScoped<IValidator<CreateClientRequest>, CreateClientRequestValidator>();

        return services;
    }
}
