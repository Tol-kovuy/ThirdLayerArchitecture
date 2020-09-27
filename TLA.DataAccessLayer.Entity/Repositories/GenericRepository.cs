using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TLA.DataAccessLayer.Entity.Context;
using TLA.DataAccessLayer.Entity.Interfaces;

namespace TLA.DataAccessLayer.Entity.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly TLAContext context;
        private DbSet<TEntity> dbSet;

        public GenericRepository(TLAContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public TEntity Get(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<TEntity> Find(Func<TEntity, Boolean> predicate)
        {
            return dbSet.Where(predicate);
        }

    }
}