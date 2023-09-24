namespace Banking.API.RestModels.Client;
public sealed record CreateClientRequest
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string PasswordHash { get; init; }
}
