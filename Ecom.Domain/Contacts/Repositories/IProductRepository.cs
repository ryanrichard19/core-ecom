using System.Collections.Generic;
using Ecom.Domain.Entities;

namespace Ecom.Domain.Contacts.Repositories
{
    public interface IProductRepository
    {
        bool AddProduct(Product product);
        Product GetProduct(int id);
        bool RemoveProduct(int id);
        ICollection<Product> GetAllProducts();
    }
}
