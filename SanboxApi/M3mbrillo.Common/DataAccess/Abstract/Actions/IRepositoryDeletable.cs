using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Abstract.Actions
{
    public interface IRepositoryDeletable : IRepositoryAction
    {
        void Delete(object entity);

        void Delete(IEnumerable<object> entities);
    }

    public interface IRepositoryDeletable<TEntity> : IRepositoryDeletable
        where TEntity : class, new()
    {
        public void Delete(TEntity entity);

        public void Delete(IEnumerable<TEntity> entities);

        void IRepositoryDeletable.Delete(object entity) => this.Delete(entity as TEntity);

        void IRepositoryDeletable.Delete(IEnumerable<object> entities) => this.Delete(entities as IEnumerable<TEntity>);
    }
}
