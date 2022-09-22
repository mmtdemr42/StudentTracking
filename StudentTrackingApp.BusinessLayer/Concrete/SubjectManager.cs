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
    public class SubjectManager : GenericService<Subject>, ISubjectService
    {
        private readonly IRepository<Subject> _repository;

        public SubjectManager(IRepository<Subject> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
