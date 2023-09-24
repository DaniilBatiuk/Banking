namespace Banking.API.RestModels.Client;
public sealed record DeleteClientResponse
{
    public int Id { get; }

    public DeleteClientResponse(int id)
    {
        Id = id;
    }
}
