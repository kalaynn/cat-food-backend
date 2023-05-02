namespace WebStore.API.Requests;

public class DeleteProductRequest
{
    public DeleteProductRequest(Guid id)
    {
        Id = id;
    }
    
    public Guid Id { get; set; }
    
}