namespace Banking.API.RestModels.Account;

public sealed record CreateAccountRequest
{
    public int ClientId { get; init; }
    public decimal Balance { get; init; }
}
