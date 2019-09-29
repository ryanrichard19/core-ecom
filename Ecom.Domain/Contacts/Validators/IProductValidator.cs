using System;
using Ecom.Domain.Entities;

namespace Ecom.Domain.Contacts.Validators
{
    public interface IProductValidator:IValidator<Product>
    {
        bool Valid(Product product);
    }
}
