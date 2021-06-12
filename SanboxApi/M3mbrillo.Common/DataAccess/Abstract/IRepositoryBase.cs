using M3mbrillo.Common.DataAccess.Abstract.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3mbrillo.Common.DataAccess.Abstract
{
    /// <summary>
    ///     Most heitghest level of repository
    /// </summary>
    public interface IRepositoryBase
    {
    }

    public interface IRepositoryReable : IRepositoryBase,
        IRepositorySelectable
    {
    
    }

    public interface IRepositoryWriteable : IRepositoryBase,
        IRepositoryInsertable, IRepositoryDeletable, IRepositoryUpdatable
    {

    }

    public interface IRepositoryCrud :
        IRepositoryWriteable,
        IRepositoryReable
    {

    }


    /// <summary>
    ///     Most heitghest level of repository
    /// </summary>
    public interface IRepositoryBase<TEntity> where TEntity : class, new()
    {
    }

    public interface IRepositoryReable<TEntity>  : IRepositoryBase<TEntity>, IRepositorySelectable<TEntity>
        where TEntity : class, new()
    {

    }

    public interface IRepositoryWriteable<TEntity> : IRepositoryBase<TEntity>,
        IRepositoryInsertable<TEntity>, IRepositoryDeletable<TEntity>, IRepositoryUpdatable<TEntity>
        where TEntity : class, new()
    {

    }

    public interface IRepositoryCrud<TEntity> :
        IRepositoryWriteable<TEntity>,
        IRepositoryReable<TEntity>
        where TEntity : class, new()
    {

    }





}
