using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQueryFilter
{
    public interface IFilterConfigurationExpression<TFilter, TTarget>
    {
        IFilterConfigurationExpression<TFilter, TTarget> ForProperty<TResult>(
            Expression<Func<TTarget, TResult>> targetPropertyExpression,
            Action<IFilterPropertyConfigurationOptions<TFilter, TTarget, TResult>> options);
    }

    public interface IFilterConfigurationExpression
    {

    }
}
