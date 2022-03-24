using System;
using System.Collections.Generic;
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
        void Insert(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entity);
        void Update(TEntity entity);

    }
}
