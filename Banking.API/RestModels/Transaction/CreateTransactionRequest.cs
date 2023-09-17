namespace Banking.API.RestModels.Transaction;

public sealed record CreateTransactionRequest
{
    public int AccountId { get; set; }
    public string TransactionType { get; set; }
    public decimal Amount { get; set; }
}
