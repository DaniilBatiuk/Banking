using Banking.API.RestModels.Client;
using Banking.API.RestModels.Transaction;
using Banking.PostgreSQL.Commands.Client.Create;
using Banking.PostgreSQL.Commands.Transaction.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers.Transaction;

[ApiController]
[Route("transactions")]
[ApiExplorerSettings(GroupName = "transactions")]
public sealed class CreateTransactionController : ControllerBase
{
    private readonly ICreateTransactionCommand _createTransaction;

    public CreateTransactionController(ICreateTransactionCommand createTransaction)
    {
        _createTransaction = createTransaction;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] CreateTransactionRequest request)
    {

        CreateTransactionDto dto = new CreateTransactionDto(
            request.AccountId,
            request.TransactionType,
            request.Amount
        );


        await _createTransaction.Execute(dto);

        return Ok();
    }
}
