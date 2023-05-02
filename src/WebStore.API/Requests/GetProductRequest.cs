namespace WebStore.API.Requests;

public class GetProductRequest
{
    public GetProductRequest(Guid id)
    {
        Id = id;
    }
    
    public Guid Id { get; set; }
    
}