using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQueryFilter
{
    public class FilterConfigurationExpression<TFilter, TTarget> : IFilterConfigurationExpression<TFilter, TTarget>, IFilterConfigurationExpression
    {
        public IFilterConfigurationExpression<TFilter, TTarget> ForProperty<TTargetProperty>(
            Expression<Func<TTarget, TTargetProperty>> targetPropertyExpression, 
            Action<IFilterPropertyConfigurationOptions<TFilter, TTarget, TTargetProperty>> options)
        {
            throw new NotImplementedException();
        }

        public IFilterConfigurationExpression<TFilter, TTarget> IgnoreFilterProperty<TFilterProperty>(
            Expression<Func<TFilter, TFilterProperty>> targetPropertyExpression)
        {
            throw new NotImplementedException();
        }

        public IFilterConfigurationExpression<TFilter, TTarget> IgnoreUnusedFilterProperties()
        {
            throw new NotImplementedException();
        }
    }
}
