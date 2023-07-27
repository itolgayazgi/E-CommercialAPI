using E_CommercialAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_CommercialAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        //Select functions
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate); 
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(string id);
    }
}
