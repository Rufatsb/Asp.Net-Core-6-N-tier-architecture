using Emobile_Task.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.DAL.Repositories.Abstractions
{
    public interface IRepository<T> where T : class,IEntityBase,new()
    {
        Task AddAsync(T entity);
        Task<List<T>> GetAllsync(Expression<Func<T, bool>>? predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<T>GetbyIdAsync(int id);
        Task DeleteAsync(T Entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>>? predicate);

    }
}
