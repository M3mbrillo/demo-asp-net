using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Abstract.Actions
{
    public interface IRepositoryInsertable : IRepositoryAction
    {
        public object Insert(object entity);
    }

    public interface IRepositoryInsertable<TEntity> : IRepositoryInsertable
        where TEntity : class, new()
    {
        public TEntity Insert(TEntity entity);

        object IRepositoryInsertable.Insert(object entity) => this.Insert(entity as TEntity);
    }
}
