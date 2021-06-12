using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Dapper.Extensions
{
    public static class ListColumnDefinitionExtensions
    {

        public static ModelDefinition.ColumnDefinition Col<TModel, TProp>(
            this List<ModelDefinition.ColumnDefinition> columnDefinitions,
            Expression<Func<TModel, TProp>> PropSelector
        )
        {
            throw new NotImplementedException();
        }

    }
}
