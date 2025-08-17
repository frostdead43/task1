namespace ProductApi.Repositories;

public interface ProductService
{
    Task<List<Product>> GetProductsAsync();
}