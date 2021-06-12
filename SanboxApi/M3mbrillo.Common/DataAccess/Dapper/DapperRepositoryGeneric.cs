using Dapper;
using M3mbrillo.Common.Logger.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Dapper
{

    public class DapperRepositoryGeneric<TDapperEntity> : DapperRepositoryBase<TDapperEntity>
        where TDapperEntity : DapperEntity, new()
    {
        public DapperRepositoryGeneric(IDbConnection connection, ILogger logger)
            : base(connection, logger)
        {

        }

        public override void Delete(TDapperEntity entity)
        {            
            this.Connection.Execute(TableDefinition.Query.DeleteByPk, entity);
        }

        public override void Delete(IEnumerable<TDapperEntity> entities)
        {
            foreach (var entity in entities)
            {
                this.Connection.Execute(TableDefinition.Query.DeleteByPk, entity);
            }
        }

        public override TDapperEntity Get(TDapperEntity entity)
        {
            var query = TableDefinition.Query.SelectAll;

            return this.Connection.Query<TDapperEntity>(query, entity).FirstOrDefault();
        }

        public override IEnumerable<TDapperEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public override TDapperEntity Insert(TDapperEntity entity)
        {
            throw new NotImplementedException();
        }

        public override TDapperEntity Update(TDapperEntity entity)
        {
            var query = TableDefinition.Query.UpdateAllFieldByPk;

            this.Connection.Execute(query, entity);

            return this.Get(entity);
        }
    }
}
