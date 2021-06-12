using M3mbrillo.Common.DataAccess.Dapper.ModelDefinition;
using M3mbrillo.Common.Logger.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Dapper
{
    public abstract class DapperRepositoryBase<TDapperEntity> : Abstract.IRepositoryCrud<TDapperEntity>
        where TDapperEntity : DapperEntity, new() 
    {
        public DapperRepositoryBase(IDbConnection connection, ILogger logger)
        {
            Connection = connection;
            Logger = logger;


            TableDefinition = TableDefinition.GetOrBuild<TDapperEntity>();
        }

        protected IDbConnection Connection { get; }
        protected ILogger Logger { get; }
        protected TableDefinition TableDefinition { get; }

        public abstract void Delete(TDapperEntity entity);
        public abstract void Delete(IEnumerable<TDapperEntity> entities);
        public abstract TDapperEntity Get(TDapperEntity entity);
        public abstract IEnumerable<TDapperEntity> GetAll();
        public abstract TDapperEntity Insert(TDapperEntity entity);
        public abstract TDapperEntity Update(TDapperEntity entity);
    }

}
