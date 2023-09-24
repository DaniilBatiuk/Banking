namespace Banking.API.RestModels.Transaction;

public sealed record CreateTransactionRequest
{
    public int AccountId { get; init; }
    public string TransactionType { get; init; }
    public decimal Amount { get; init; }
}
