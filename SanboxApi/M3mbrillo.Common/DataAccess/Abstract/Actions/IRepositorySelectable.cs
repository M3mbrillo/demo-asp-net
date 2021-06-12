using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Abstract.Actions
{
    public interface IRepositorySelectable : IRepositoryAction
    {
        bool Exist(object entity) => this.Get(entity) != null;

        object Get(object entity);

        IEnumerable<object> GetAll();
    }

    public interface IRepositorySelectable<TEntity> : IRepositorySelectable
        where TEntity : class, new()
    {
        bool Exist(TEntity entity) => this.Get(entity) != null;

        TEntity Get(TEntity entity);

        new IEnumerable<TEntity> GetAll();


        bool IRepositorySelectable.Exist(object entity) => this.Exist(entity as TEntity);

        object IRepositorySelectable.Get(object entity) => this.Get(entity as TEntity);

        IEnumerable<object> IRepositorySelectable.GetAll() => this.GetAll();
    }
}
