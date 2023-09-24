namespace Banking.API.RestModels.TransactionHistory;

public sealed record CreateTransactionHistoryRequest
{
    public int TransactionId { get; init; }
    public string OperationDetails { get; init; }
}
