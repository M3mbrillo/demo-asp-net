using M3mbrillo.Common.DataAccess.Abstract;
using M3mbrillo.Common.Logger.Abstract;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Dapper
{
    public interface IDapperProvider : Abstract.IRepositoryProvider
    {
        IDbTransaction BeginTransaction();
        IDbTransaction dbTransaction(IsolationLevel isolationLevel);
    }


    public class DapperProvider : IDapperProvider
    {
        protected IDbConnection Connection { get; }
        protected ILogger Logger { get; }


        private ConcurrentDictionary<string, object> ActiveRepos { get; } = new ConcurrentDictionary<string, object>();

        public DapperProvider(IDbConnection connection, ILogger logger)
        {
            this.Connection = connection;
            this.Logger = logger;
        }

        public IDbTransaction BeginTransaction() => this.Connection.BeginTransaction();

        public IDbTransaction dbTransaction(IsolationLevel isolationLevel) => this.Connection.BeginTransaction(isolationLevel);

        TRepo IRepositoryProvider.GetRepository<TRepo>()
        {
            var type = typeof(TRepo);
            var typeName = typeof(TRepo).FullName;

            // TODO use a real DI 
            if (!this.ActiveRepos.ContainsKey(typeName))
                this.ActiveRepos.TryAdd(typeName, Activator.CreateInstance(type, this.Connection, this.Logger) as TRepo);

            return (TRepo)this.ActiveRepos[typeName];
        }
    }

}
