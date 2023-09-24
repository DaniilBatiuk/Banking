using Banking.API.RestModels.Client;
using Banking.PostgreSQL.CQRS.Client.Commands.Create;
using Banking.PostgreSQL.CQRS.Client.Commands.Delete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers.Client;

[ApiController]
[Route("clients")]
[ApiExplorerSettings(GroupName = "clients")]
public sealed class DeleteClientController : ControllerBase
{
    private readonly IDeleteClientCommandHandler _deleteClientCommandHandler;

    public DeleteClientController(IDeleteClientCommandHandler deleteClientCommandHandler)
    {
        _deleteClientCommandHandler = deleteClientCommandHandler;
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromBody] DeleteClientRequest request)
    {

        try
        {
            DeleteClientCommand deleteClientCommand = new DeleteClientCommand(
           request.Id
           );

            await _deleteClientCommandHandler.Handle(deleteClientCommand);
            return Ok("Account deleted successfully");
        }
        catch (Exception ex)
        {
            return BadRequest($"Error deleting account: {ex.Message}");
        }
    }
}
