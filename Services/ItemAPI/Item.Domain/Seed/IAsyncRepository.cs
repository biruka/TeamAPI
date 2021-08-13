﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Item.Domain.Seed
{
   public interface IAsyncRepository<T> where T : BaseAuditModel
    {
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetByIdAsync(Guid id);
        Task<IQueryable<T>> GetQueryAsync(Expression<Func<T, bool>> predicate);

        Task<IReadOnlyList<T>> GetAllAsync();

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);

    }
}
