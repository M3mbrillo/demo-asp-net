using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Abstract
{
    /// <summary>
    ///     Work as such as Unit of Work!
    /// </summary>
    public interface IRepositoryProvider
    {
        TRepo GetRepository<TRepo>()
            where TRepo : class, IRepositoryBase, new();
    }
}
