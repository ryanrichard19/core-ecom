using Ecom.Domain.Entities;

namespace Ecom.Domain.Contacts.Repositories
{
    public interface IProductRepository
    {
        bool Create(Product product);
    }
}
