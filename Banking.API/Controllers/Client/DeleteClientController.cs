using Banking.API.RestModels.Client;
using Banking.PostgreSQL.Commands.Client.Create;
using Banking.PostgreSQL.Commands.Client.Delete;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers.Client;

[ApiController]
[Route("clients")]
[ApiExplorerSettings(GroupName = "clients")]
public sealed class DeleteClientController : ControllerBase
{
    private readonly IDeleteClientCommand _deleteClient;

    public DeleteClientController(IDeleteClientCommand deleteClient)
    {
        _deleteClient = deleteClient;
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromBody] DeleteClientRequest request)
    {

        DeleteClientDto dto = new DeleteClientDto(
            request.Id
        );

        try
        {
            await _deleteClient.Execute(dto);
            return Ok("Account deleted successfully");
        }
        catch (Exception ex)
        {
            return BadRequest($"Error deleting account: {ex.Message}");
        }
    }
}
