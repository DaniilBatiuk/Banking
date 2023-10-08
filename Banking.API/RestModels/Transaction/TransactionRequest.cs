namespace Banking.API.RestModels.Transaction;

public sealed record TransactionRequest
{
    public int AccountId { get; init; }
    public decimal Amount { get; init; }
}
