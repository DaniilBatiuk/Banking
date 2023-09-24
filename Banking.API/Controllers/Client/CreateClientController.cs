using Banking.API.RestModels.Client;
using Banking.PostgreSQL.CQRS.Client.Commands.Create;
using Banking.PostgreSQL.CQRS.Client.Queries.FindClient;
using Banking.PostgreSQL.Dtos.Client;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers.Client;

[ApiController]
[Route("clients")]
[ApiExplorerSettings(GroupName = "clients")]
public sealed class CreateClientController : ControllerBase
{
    private readonly IValidator<CreateClientRequest> _validator;
    private readonly ICreateClientCommandHandler _createClientCommandHandler;
    private readonly IFindClientQueryHandler _findClientQueryHandler;
    private readonly ILogger<CreateClientController> _logger;

    public CreateClientController(
        ICreateClientCommandHandler createClientCommandHandler, IValidator<CreateClientRequest> validator, ILogger<CreateClientController> logger, IFindClientQueryHandler findClientQueryHandler)
    {
        _createClientCommandHandler = createClientCommandHandler;
        _validator = validator;
        _logger = logger;
        _findClientQueryHandler = findClientQueryHandler;
    }

    [HttpPost("create")]
    public async Task<ActionResult<CreateClientResponse>> Create([FromBody] CreateClientRequest request)
    {
        ValidationResult validationResult = await _validator.ValidateAsync(request);

        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors.Select(e => new { e.PropertyName, e.ErrorMessage }));
        }

        string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.PasswordHash);

        try
        {
            CreateClientCommand createClientCommand = new CreateClientCommand(
                request.FirstName,
                request.LastName,
                request.Email,
                passwordHash);

            await _createClientCommandHandler.Handle(createClientCommand);

            ClientDto? client = await _findClientQueryHandler.Handle(new FindClientQuery(request.Email));

            if (client != null)
            {
                CreateClientResponse response = new CreateClientResponse(
                    client.FirstName,
                    client.LastName,
                    client.Email,
                    client.PasswordHash
                    );

                return Ok(response);
            }
            else
            {
                _logger.LogError($"Could not find user after creations");

                return BadRequest();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error occured during the user creation process");

            return Problem("Something went wrong");
        }
    }
}
