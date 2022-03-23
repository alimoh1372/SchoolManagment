﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.DataLayer
{
    public class BaseRepository<TEntity> where TEntity : class, IBaseRepository<TEntity>
    {
        private SchoolManagmentEntities _db;

        private DbSet<TEntity> _dbSet;

        public BaseRepository(SchoolManagmentEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }
        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (where != null)
            {
                query = _dbSet.Where(where);
            }

            return query.ToList();
        }
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        public virtual void Delete(object id)
        {
            TEntity entity = GetById(id);
            Delete(entity);
        }
        void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
                _db.Entry(entity).State = EntityState.Modified;
            }
            _db.Entry(entity).State = EntityState.Deleted;
        }
        void Update(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _db.Entry(entity).State = EntityState.Modified;
        }
    }
}
