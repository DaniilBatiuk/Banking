namespace Banking.API.RestModels.Account;

public sealed record CreateAccountRequest
{
    public int ClientId { get; set; }
    public decimal Balance { get; set; }
}
