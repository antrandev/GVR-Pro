using System;
using System.Linq;
using System.Linq.Expressions;

namespace Data.BaseRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IQueryable<TEntity> Query<TEntity>() where TEntity : class;

    }
}
