﻿using E_CommercialAPI.Application.Repositories;
using E_CommercialAPI.Domain.Common;
using E_CommercialAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_CommercialAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        readonly E_CommercialAPIDbContext _context;

        public ReadRepository(E_CommercialAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() 
            => Table;
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate) 
            => Table.Where(predicate);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate) 
            => await Table.FirstOrDefaultAsync(predicate);

        public async Task<T> GetByIdAsync(string id)
            => await Table.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
       
    }
}
