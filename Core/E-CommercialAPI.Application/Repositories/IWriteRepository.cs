using E_CommercialAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommercialAPI.Application.Repositories
{
    public interface IWriteRepository<T> :IRepository<T> where T : BaseEntity
    {
        //Write functions
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        bool Remove(T entity);
        bool RemoveRange(List<T> entities);
        Task<bool> RemoveAsync(string id);
        bool Update(T entity);
        Task<int> SaveAsync();
    }
}
