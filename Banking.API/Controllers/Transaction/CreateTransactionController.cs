using Banking.API.RestModels.Transaction;
using Banking.PostgreSQL.CQRS.Account.Create;
using Banking.PostgreSQL.CQRS.Transaction.Create;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers.Transaction;

[ApiController]
[Route("transactions")]
[ApiExplorerSettings(GroupName = "transactions")]
public sealed class CreateTransactionController : ControllerBase
{
    private readonly ICreateTransactionCommandHandler _createTransactionCommandHandler;
    private readonly ILogger<CreateTransactionController> _logger;

    public CreateTransactionController(
        ICreateTransactionCommandHandler createTransactionCommandHandler, ILogger<CreateTransactionController> logger)
    {
        _createTransactionCommandHandler = createTransactionCommandHandler;
        _logger = logger;
    }

    [HttpPost("create")]
    public async Task<ActionResult<CreateTransactionResponse>> Create([FromBody] CreateTransactionRequest request)
    {

        try
        {
            CreateTransactionCommand createTransactionCommand = new CreateTransactionCommand(
               request.AccountId,
            request.TransactionType,
            request.Amount);

            await _createTransactionCommandHandler.Handle(createTransactionCommand);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error occured during the user creation process");

            return Problem("Something went wrong");
        }
    }
}
