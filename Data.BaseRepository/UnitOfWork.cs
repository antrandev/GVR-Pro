using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DataContext context { get; internal set; }

        public UnitOfWork(DataContext _context)
        {
            context = _context;
        }

        public IQueryable<TEntity> Query<TEntity>() where TEntity : class
        {
            return  context.Set<TEntity>().AsQueryable();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}


