using System;
using Ecom.Domain.Contacts.Validators;
using Ecom.Domain.Entities;

namespace Ecom.BLL.Validators
{
    public class ProductValidator: IValidator<Product>
    {
        public ProductValidator()
        {
        }

        public bool IsValid(Product entity)
        {
            return (!string.IsNullOrEmpty(entity.Name) &&
                    entity.Price > 0 &&
                    (!string.IsNullOrEmpty(entity.Description)));
        }
    }
}
