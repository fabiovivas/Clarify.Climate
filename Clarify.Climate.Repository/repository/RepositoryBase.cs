using Clarify.Climate.Domain.interfaces.Repository;
using Clarify.Climate.Repository.context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Clarify.Climate.Repository.repository
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ClimateContext Context;

        public RepositoryBase()
        {
            Context = new ClimateContext();
        }

        public List<TEntity> Filter(Expression<Func<TEntity, bool>> predicate, string[] includes = null)
        {
            var ListEntity = this.Context.Set<TEntity>().Where(predicate);
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    ListEntity = ListEntity.Include(include);
                }
            }
            return ListEntity.ToList();
        }
        public List<TEntity> getAll()
        {
            return Context.Set<TEntity>().ToList();
        }
    }
}
