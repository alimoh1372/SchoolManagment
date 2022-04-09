using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.DataLayer
{
    public interface IBaseRepository<TEntity>where TEntity:class
    {
        TEntity GetById(object id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null);
        IEnumerable<TEntity> GetIncludeEntities<LEntity>(Expression<Func<TEntity, LEntity>> include);
        IEnumerable<TEntity> GetIncludeEntities<LEntity, FEntity>(Expression<Func<TEntity, LEntity>> include1, Expression<Func<TEntity, FEntity>> include2)
            where LEntity:class
            where FEntity:class;
        IEnumerable<TEntity> GetIncludeEntities<LEntity, FEntity, NEntity>(Expression<Func<TEntity, LEntity>> include1, Expression<Func<TEntity, FEntity>> include2, Expression<Func<TEntity, NEntity>> include3)
            where LEntity : class
            where FEntity : class
            where NEntity : class;
        void Insert(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entity);
        void Update(TEntity entity);

    }
}
