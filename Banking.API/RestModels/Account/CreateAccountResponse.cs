namespace Banking.API.RestModels.Account;

public sealed record CreateAccountResponse
{
    public int ClientId { get; set; }
    public decimal Balance { get; set; }

    public CreateAccountResponse(int clientId, decimal balance)
    {
        ClientId = clientId;
        Balance = balance;
    }
}
