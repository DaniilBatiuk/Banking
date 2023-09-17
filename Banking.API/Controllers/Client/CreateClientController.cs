using Banking.API.RestModels.Client;
using Banking.PostgreSQL.Commands.Client.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers.Client;

[ApiController]
[Route("clients")]
[ApiExplorerSettings(GroupName = "clients")]
public sealed class CreateClientController : ControllerBase
{
    private readonly ICreateClientCommand _createClient;

    public CreateClientController(ICreateClientCommand createClient)
    {
        _createClient = createClient;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] CreateClientRequest request)
    {

        CreateClientDto dto = new CreateClientDto(
            request.FirstName,
            request.LastName,
            request.Email,
            request.PasswordHash
        );


        await _createClient.Execute(dto);

        return Ok();
    }
}
