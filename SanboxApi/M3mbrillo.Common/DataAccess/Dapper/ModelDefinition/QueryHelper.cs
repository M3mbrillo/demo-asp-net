using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Dapper.ModelDefinition
{
    // TODO maybe is necesarry a many QueryHelper for distinct database types
    // isnt the same sintax in mysql and sql server, ex, limit 1 vs top 1 on select query
    public class QueryHelper
    {
        TableDefinition TableDefinition { get; }

        public QueryHelper(TableDefinition tableDefinition)
        {
            TableDefinition = tableDefinition;
        }


        /// <summary>
        ///     return normalized table name.
        ///     Ex:
        ///         [dbo].[user system]
        ///         [user system]
        ///         [User]
        /// </summary>
        public string TableName => throw new NotImplementedException();


        /// <summary>
        ///     get the query parametizer to filter by the primary key column.
        ///     Example if the PK is column Id and Name, this prop return 
        ///     Id = @Id and Name = @Name
        /// </summary>
        public string MatchPrimaryKey => throw new NotImplementedException();


        /// <summary>
        ///   get a query for select using the Pk
        /// </summary>
        public string DeleteByPk => $"DELETE FROM {TableName} T WHERE T.{MatchPrimaryKey};";

        /// <summary>
        ///     get all columns separed by ,
        ///     Ex:
        ///         [table].[column1], [table].[column2], [table].[column3]
        ///         
        /// </summary>
        public string AllColumns => throw new NotImplementedException();


        public string SelectAll => $"SELECT {AllColumns} FROM {TableName}";

        // TODO add setting class to switch limit 1 (mysql, sqllite) and top 1 (MS SQL)
        public string SelectByPK => throw new NotImplementedException();

        public string UpdateByPk<T, Prop>(params Expression<Func<T, Prop>>[] updateProperties)
        {
            throw new NotImplementedException();
        }

        public string UpdateAllFieldByPk => throw new NotImplementedException();
        
    }
}
