
using OneReview.Domain;

namespace OneReview.Services;
public class ProductService
{

    private static readonly List<Product> ProductsRepository = [];  
    public void Create(Product product)
    {
        ProductsRepository.Add(product);    
    }
    public Product? Get(Guid productId)    {
        return ProductsRepository.Find(p => p.Id.Equals(productId));
    }
}
