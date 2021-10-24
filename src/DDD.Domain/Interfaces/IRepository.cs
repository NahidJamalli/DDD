using System;
using System.Collections.Generic;
using System.Linq;

namespace DDD.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        void AddRange(List<TEntity> obj);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(ISpecification<TEntity> spec);
        IQueryable<TEntity> GetAllSoftDeleted();
        void Update(TEntity obj);
        void Remove(Guid id);
        int SaveChanges();
    }
}
