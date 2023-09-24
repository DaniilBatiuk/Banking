using Banking.API.RestModels.Client;
using FluentValidation;

namespace Banking.API.RestModels.Validators.Client;

public sealed class CreateClientRequestValidator : AbstractValidator<CreateClientRequest>
{
    public CreateClientRequestValidator()
    {
        RuleFor(r => r.FirstName)
            .NotNull()
            .NotEmpty()
            .WithMessage("First name is required");

        RuleFor(r => r.LastName)
            .NotNull()
            .NotEmpty()
            .WithMessage("Last name is required");
    }
}
