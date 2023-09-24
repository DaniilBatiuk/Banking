using Banking.API.RestModels.Account;
using Banking.API.RestModels.Client;
using Banking.PostgreSQL.CQRS.Account.Create;
using Banking.PostgreSQL.CQRS.Client.Commands.Create;
using Banking.PostgreSQL.CQRS.Client.Queries.FindClient;
using Banking.PostgreSQL.Dtos.Account;
using Banking.PostgreSQL.Dtos.Client;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CreateAccountCommand = Banking.PostgreSQL.CQRS.Account.Create.CreateAccountCommand;

namespace Banking.API.Controllers.Account;

[ApiController]
[Route("accounts")]
[ApiExplorerSettings(GroupName = "accounts")]
public sealed class CreateAccountController : ControllerBase
{
    private readonly ICreateAccountCommandHandler _createAccountCommandHandler;
    private readonly ILogger<CreateAccountController> _logger;

    public CreateAccountController(
        ICreateAccountCommandHandler createAccountCommandHandler, ILogger<CreateAccountController> logger)
    {
        _createAccountCommandHandler = createAccountCommandHandler;
        _logger = logger;
    }

    [HttpPost("create")]
    public async Task<ActionResult<CreateAccountResponse>> Create([FromBody] CreateAccountRequest request)
    {

        try
        {
            CreateAccountCommand createAccountCommand = new CreateAccountCommand(
                request.ClientId,
                request.Balance);

            await _createAccountCommandHandler.Handle(createAccountCommand);

                return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error occured during the user creation process");

            return Problem("Something went wrong");
        }
    }
}
