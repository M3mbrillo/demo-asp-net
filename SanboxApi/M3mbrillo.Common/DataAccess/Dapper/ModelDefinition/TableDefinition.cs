using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Dapper.ModelDefinition
{
    public class TableDefinition
    {

        public static TableDefinition GetOrBuild<TDapperEntity>()
        {
            throw new NotImplementedException();
        }

        public string TableName { get; set; }
        public string Scheme { get; set; }

        public QueryHelper Query { get; init; }

        public List<ColumnDefinition> Columns { get; set; }        


    }
}
