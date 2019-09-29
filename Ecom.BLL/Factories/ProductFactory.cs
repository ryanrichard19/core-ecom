using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecom.Data.Contexts;
using Ecom.Domain.Contacts.Factories;
using Ecom.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecom.BLL.Factories
{
    public class ProductFactory: IEntityFactory<Product>
    {
        private EcomDbContext _db;

        public ProductFactory(EcomDbContext db)
        {
            _db = db;
        }

        public async Task<bool> CreateAsync(Product entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            return await Task<bool>.Factory.StartNew(() =>
            {
                _db.Products.AddAsync(entity);
                _db.SaveChangesAsync();
                return true;
            });     
        }

        public Task<Product> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Product>> GetAllAsync()
        {
            if (!await _db.Products.AnyAsync())
                return null;
            else
                return await _db.Products.ToListAsync();
        }

        public Task<bool> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
