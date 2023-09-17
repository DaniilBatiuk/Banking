using Banking.API.RestModels.Transaction;
using Banking.API.RestModels.TransactionHistory;
using Banking.PostgreSQL.Commands.Transaction.Create;
using Banking.PostgreSQL.Commands.TransactionHistory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers.TransactionHistory;

[ApiController]
[Route("transactionHistorys")]
[ApiExplorerSettings(GroupName = "transactionHistorys")]
public sealed class CreateTransactionHistoryController : ControllerBase
{
    private readonly ICreateTransactionHistoryCommand _createTransactionHistory;

    public CreateTransactionHistoryController(ICreateTransactionHistoryCommand createTransactionHistory)
    {
        _createTransactionHistory = createTransactionHistory;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] CreateTransactionHistoryRequest request)
    {

        CreateTransactionHistoryDto dto = new CreateTransactionHistoryDto(
            request.TransactionId,
            request.OperationDetails
        );


        await _createTransactionHistory.Execute(dto);

        return Ok();
    }
}
