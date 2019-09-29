using System;
using System.Collections.Generic;
using Ecom.Domain.Contacts.Factories;
using Ecom.Domain.Contacts.Handlers;
using Ecom.Domain.Contacts.Managers;
using Ecom.Domain.Contacts.Repositories;
using Ecom.Domain.Contacts.Validators;
using Ecom.Domain.Entities;

namespace Ecom.BLL.Managers
{
    public class ProductManager : IProductRepository
    {
        private IEntityFactory<Product> _factory;
        private IValidator<Product> _validator;
        private IExceptionHandler _handler;

        public ProductManager(IEntityFactory<Product> factory, IValidator<Product> validator, IExceptionHandler handler)
        {
            _factory = factory;
            _validator = validator;
            _handler = handler;
        }


        public bool AddProduct(Product product)
        {
            if (_validator.IsValid(product))
                return _handler.Run(() => _factory.CreateAsync(product).Result);
            return false;
        }

        public ICollection<Product> GetAllProducts()
        {
            return _handler.Run(() => _factory.GetAllAsync().Result);
        }


        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }


        public bool RemoveProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
