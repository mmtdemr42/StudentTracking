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
    public class StudentManager : GenericService<Student>, IStudentService
    {
        private readonly IRepository<Student> _repository;
        public StudentManager(IRepository<Student> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
