using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clarify.Climate.Domain.interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> Filter(Expression<Func<TEntity, bool>> predicate, string[] includes = null);
        List<TEntity> getAll();
    }
}
