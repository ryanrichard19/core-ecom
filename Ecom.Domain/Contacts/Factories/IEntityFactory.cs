using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecom.Domain.Entities.BaseModels;

namespace Ecom.Domain.Contacts.Factories
{
    public interface IEntityFactory<T> where T:BaseEntity
    {
        Task<bool> CreateAsync(T entity);
        Task<T> GetAsync(int id);
        Task<bool> RemoveAsync(int id);
        Task<ICollection<T>> GetAllAsync();
    }
}
