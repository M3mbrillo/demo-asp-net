using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Abstract.Actions
{
    public interface IRepositoryUpdatable : IRepositoryAction
    {
        object Update(object entity);
    }

    public interface IRepositoryUpdatable<TEntity> : IRepositoryUpdatable
        where TEntity : class, new()
    {
        TEntity Update(TEntity entity);

        object IRepositoryUpdatable.Update(object entity) => this.Update(entity as TEntity);
    }

}
