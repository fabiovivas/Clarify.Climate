using Clarify.Climate.Domain.interfaces.Business;
using Clarify.Climate.Domain.interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clarify.Climate.Business
{
    public class BusinessBase<TEntity> : IBusiness<TEntity> where TEntity : class
    {
        internal readonly IRepository<TEntity> repo;

        public BusinessBase(IRepository<TEntity> repo)
        {
            this.repo = repo;
        }
        public List<TEntity> Filter(Expression<Func<TEntity, bool>> predicate, string[] includes = null)
        {
            return repo.Filter(predicate, includes);
        }

        public List<TEntity> getAll()
        {
            return repo.getAll();
        }
    }
}
