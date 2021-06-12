using M3mbrillo.Common.Logger.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxApi.Database
{
    public class DatabaseContext : M3mbrillo.Common.DataAccess.Dapper.DapperProvider,
        Abstract.IDatabaseContext
    {
        public DatabaseContext(IDbConnection connection, ILogger logger) : base(connection, logger)
        {
        }
    }
}
