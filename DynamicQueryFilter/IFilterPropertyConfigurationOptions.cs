using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQueryFilter
{
    public interface IFilterPropertyConfigurationOptions<TFilter, TTarget, TTargetProperty>
    {
        void EqualTo<TFilterProperty>(Expression<Func<TFilter, TFilterProperty>> filterPropertyExpression) 
            where TFilterProperty : IComparable<TTargetProperty>;
        void MoreThanOrEqual<TFilterProperty>(Expression<Func<TFilter, TFilterProperty>> filterPropertyExpression)
            where TFilterProperty : IComparable<TTargetProperty>;
        void LessThanOrEqual<TFilterProperty>(Expression<Func<TFilter, TFilterProperty>> filterPropertyExpression)
            where TFilterProperty : IComparable<TTargetProperty>;
        void MoreThan<TFilterProperty>(Expression<Func<TFilter, TFilterProperty>> filterPropertyExpression)
            where TFilterProperty : IComparable<TTargetProperty>;
        void LessThan<TFilterProperty>(Expression<Func<TFilter, TFilterProperty>> filterPropertyExpression)
            where TFilterProperty : IComparable<TTargetProperty>;

        void Contains(Expression<Func<TFilter, string>> filterPropertyExpression);
        void Contained(Expression<Func<TFilter, string>> filterPropertyExpression);
        void StartsWith(Expression<Func<TFilter, string>> filterPropertyExpression);
        void EndsWith(Expression<Func<TFilter, string>> filterPropertyExpression);

        void Method<TFilterProperty>(Expression<Func<TFilter, TFilterProperty>> filterPropertyExpression,
            Expression<Func<TFilterProperty, TTargetProperty, bool>> compareFunctionExpression);
    }
}
