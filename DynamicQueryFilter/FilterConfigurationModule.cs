using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQueryFilter
{
    public class FilterConfigurationModule
    {
        private readonly ICollection<IFilterConfigurationExpression> _filterExpressions = new List<IFilterConfigurationExpression>();

        public IFilterConfigurationExpression<TFilter, TTarget> CreateFilterConfig<TTarget, TFilter>()
        {
            var filterMapping = new FilterConfigurationExpression<TFilter, TTarget>();

            _filterExpressions.Add(filterMapping);

            return filterMapping;
        }
    }
}
