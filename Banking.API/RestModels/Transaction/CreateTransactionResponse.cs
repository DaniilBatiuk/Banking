namespace Banking.API.RestModels.Transaction;

public sealed record CreateTransactionResponse
{
    public int AccountId { get; set; }
    public string TransactionType { get; set; }
    public decimal Amount { get; set; }

    public CreateTransactionResponse(int accountId, string transactionType, decimal amount)
    {
        AccountId = accountId;
        TransactionType = transactionType;
        Amount = amount;
    }
}
