using Banking.API.RestModels.Transaction;
using Banking.API.RestModels.TransactionHistory;
using Banking.PostgreSQL.CQRS.TransactionHistory.Create;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers.TransactionHistory;

[ApiController]
[Route("transactionHistorys")]
[ApiExplorerSettings(GroupName = "transactionHistorys")]
public sealed class CreateTransactionHistoryController : ControllerBase
{
    private readonly ICreateTransactionHistoryCommandHandler _createTransactionHistoryCommandHandler;
    private readonly ILogger<CreateTransactionHistoryController> _logger;

    public CreateTransactionHistoryController(
        ICreateTransactionHistoryCommandHandler createTransactionHistoryCommandHandler, ILogger<CreateTransactionHistoryController> logger)
    {
        _createTransactionHistoryCommandHandler = createTransactionHistoryCommandHandler;
        _logger = logger;
    }

    [HttpPost("create")]
    public async Task<ActionResult<CreateTransactionResponse>> Create([FromBody] CreateTransactionHistoryRequest request)
    {

        try
        {
            CreateTransactionHistoryCommand createTransactionHistoryCommand = new CreateTransactionHistoryCommand(
            request.TransactionId,
            request.OperationDetails);

            await _createTransactionHistoryCommandHandler.Handle(createTransactionHistoryCommand);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error occured during the user creation process");

            return Problem("Something went wrong");
        }
    }
}
