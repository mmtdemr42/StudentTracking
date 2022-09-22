using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.DataAccessLayer.Abstract
{
    public interface IRepository<TEntity>
    {
        List<TEntity> List();
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> List(Expression<Func<TEntity, bool>> filter);
    }
}
