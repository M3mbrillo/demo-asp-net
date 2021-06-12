using M3mbrillo.Common.DataAccess.Dapper.ModelDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Dapper
{
    public abstract class DapperEntity
    {
        public static TableDefinition TableDefinition { get; }


        //protected abstract string TableName { get; }

        //protected abstract List<ColumnDefinition> Columns { get; }
    }

    public class DapperEntity<TEntity> : DapperEntity
        where TEntity : class, new()
    {


    }
}
