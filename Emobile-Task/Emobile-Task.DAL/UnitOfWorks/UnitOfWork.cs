using Emobile_Task.DAL.Data;
using Emobile_Task.DAL.Repositories.Abstractions;
using Emobile_Task.DAL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.DAL.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmobileTaskContext _context ;
        public UnitOfWork(EmobileTaskContext context)
        {
            _context = context;
        }
        public async ValueTask DisposeAsync()
        {
            
            await _context.DisposeAsync();
    
        }

        public int Save()
        {
         return  _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();


        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new Repository<T>(_context);
        }
    }
}
