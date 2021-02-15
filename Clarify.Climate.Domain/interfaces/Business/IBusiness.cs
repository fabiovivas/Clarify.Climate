using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Clarify.Climate.Domain.interfaces.Business
{
    public interface IBusiness<TEntity> where TEntity : class
    {
        List<TEntity> Filter(Expression<Func<TEntity, bool>> predicate, string[] includes = null);
        List<TEntity> getAll();
    }
}
