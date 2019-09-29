using System;
using System.Collections.Generic;
using Ecom.Domain.Entities;

namespace Ecom.Domain.Contacts.Managers
{
    public interface IProductManager
    {
        bool Add(Product product);
        Product GetProduct(string productId);
        bool RemoveProduct(string productId);
        ICollection<Product> GetAllProducts();
    }
}
