using StudentTracking.BusinessLayer.Abstract;
using StudentTracking.BusinessLayer.Concrete.GenericService;
using StudentTracking.DataAccessLayer.Abstract;
using StudentTracking.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.BusinessLayer.Concrete
{
    public class ClassManager : GenericService<Class>, IClassService
    {
        private readonly IRepository<Class> _repository;

        public ClassManager(IRepository<Class> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
