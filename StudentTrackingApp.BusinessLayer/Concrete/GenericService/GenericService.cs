using StudentTracking.BusinessLayer.Abstract.IService;
using StudentTracking.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.BusinessLayer.Concrete.GenericService
{
    public class GenericService<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public GenericService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }


        public void Add(TEntity entity)
        {
            _repository.Insert(entity);
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public List<TEntity> List()
        {
            return _repository.List();
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
