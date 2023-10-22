using Banking.API.RestModels.Transaction;
using Banking.PostgreSQL.ChainOfResponsibility;
using Banking.PostgreSQL.CQRS.Account.Create;
using Banking.PostgreSQL.CQRS.Client.Commands.Create;
using Banking.PostgreSQL.CQRS.Transaction.Create;
using Banking.PostgreSQL.Data.Entities;
using Banking.PostgreSQL.FactoryMethod;
using Banking.PostgreSQL.Mediator;
using Banking.PostgreSQL.TemplateMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Banking.API.Controllers.Transaction;

[ApiController]
[Route("transactions")]
[ApiExplorerSettings(GroupName = "transactions")]
public sealed class CreateTransactionController : ControllerBase
{
    private readonly ILogger<CreateTransactionController> _logger;
    private readonly IMediator _mediator;
    private TransactionFactory _transactionFactory;
    private TransactionProcessor processor;
    private Approver Daniil, Anna, Oleg;

    public CreateTransactionController(ILogger<CreateTransactionController> logger, IMediator mediator)
    {
        _mediator = mediator;
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

            Daniil = new Operator();
            Anna = new Manager();
            Oleg = new HighLevelSpecialist();

            Daniil.SetSuccessor(Anna);
            Anna.SetSuccessor(Oleg);

            string result = Daniil.ProcessTransaction(createTransactionCommand);
            _logger.LogDebug(result);

            await _mediator.Send(createTransactionCommand);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error occured during the user creation process");

            return Problem("Something went wrong");
        }
    }




    [HttpPost("deposit")]
    public async Task<IActionResult> CreateDepositTransaction([FromBody] TransactionRequest request)
    {
        try
        {
            CreateTransactionCommand transaction = (_transactionFactory = new DepositTransactionFactory()).CreateTransactionAsync(request.Amount, request.AccountId);

            processor = new DepositTransactionProcessor();
            processor.ProcessTransaction(transaction);

            await _mediator.Send(transaction);
            return Ok(transaction);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error occurred during the deposit transaction creation process");
            return Problem("Something went wrong");
        }
    }


    [HttpPost("withdraw")]
    public async Task<IActionResult> CreateWithdrawTransaction([FromBody] TransactionRequest request)
    {
        try
        {
            CreateTransactionCommand transaction = (_transactionFactory  = new WithdrawTransactionFactory()).CreateTransactionAsync(request.Amount, request.AccountId);

            processor = new WithdrawTransactionProcessor();
            processor.ProcessTransaction(transaction);

            await _mediator.Send(transaction);
            return Ok(transaction);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error occurred during the withdraw transaction creation process");
            return Problem("Something went wrong");
        }
    }
}
