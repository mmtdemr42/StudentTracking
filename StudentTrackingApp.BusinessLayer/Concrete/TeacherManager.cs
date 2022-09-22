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
    public class TeacherManager : GenericService<Teacher>, ITeacherService
    {
        private readonly IRepository<Teacher> _repository;

        public TeacherManager(IRepository<Teacher> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
