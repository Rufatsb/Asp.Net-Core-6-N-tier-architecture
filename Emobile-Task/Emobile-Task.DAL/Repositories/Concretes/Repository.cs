using Emobile_Task.Core.Entities;
using Emobile_Task.DAL.Data;
using Emobile_Task.DAL.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.DAL.Repositories.Concretes
{
    public class Repository<T>: IRepository<T> where T : class,IEntityBase,new()
    {
        private readonly EmobileTaskContext context;
        public Repository(EmobileTaskContext context)
        {
            this.context = context;
        }

        private DbSet<T> Table { get => context.Set<T>(); }

        public async Task<List<T>> GetAllsync(Expression<Func<T, bool>>? predicate,params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if (predicate != null)
            {
                query = query.Where(predicate);

            }
            if (includeProperties.Any())
                foreach (var item in includeProperties)
               query = query.Include(item);
           return await query.ToListAsync();
            
        }
        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            query = query.Where(predicate);
            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                  
                        query = query.Include(item);
                  
                }

            }
            return await query.SingleAsync();

        }

        public async Task<T> GetbyIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }
       public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));

        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }

       public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate)
        {
            return await Table.CountAsync(predicate);

        }


    }
}
