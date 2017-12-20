using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQueryFilter
{
    public interface IQueryFilter
    {
        Expression<Func<TTarget, bool>> CreateSelector<TFilter, TTarget>(TFilter filter);
    }
}
