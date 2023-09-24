namespace Banking.API.RestModels.TransactionHistory;

public sealed record CreateTransalctionHistoryResponse
{
    public int TransactionId { get; set; }
    public string OperationDetails { get; set; }
    public CreateTransalctionHistoryResponse(int transactionId, string operationDetails)
    {
        TransactionId = transactionId;
        OperationDetails = operationDetails;
    }
}
