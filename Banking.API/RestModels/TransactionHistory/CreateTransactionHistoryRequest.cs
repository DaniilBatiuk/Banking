namespace Banking.API.RestModels.TransactionHistory;

public sealed record CreateTransactionHistoryRequest
{
    public int TransactionId { get; set; }
    public string OperationDetails { get; set; }
}
