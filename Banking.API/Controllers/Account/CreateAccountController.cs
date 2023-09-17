using Banking.API.RestModels.Account;
using Banking.PostgreSQL.Commands.Account.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers.Account;

[ApiController]
[Route("accounts")]
[ApiExplorerSettings(GroupName = "accounts")]
public sealed class CreateAccountController : ControllerBase
{
    private readonly ICreateAccountCommand _createAccount;

    public CreateAccountController(ICreateAccountCommand createAccount)
    {
        _createAccount = createAccount;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] CreateAccountRequest request)
    {

        CreateAccountDto dto = new CreateAccountDto(
            request.ClientId,
            request.Balance
        );


        await _createAccount.Execute(dto);

        return Ok();
    }
}
