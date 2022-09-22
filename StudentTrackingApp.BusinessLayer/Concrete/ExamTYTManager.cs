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
    public class ExamTYTManager : GenericService<ExamTYT>, IExamTYTService
    {
        private readonly IRepository<ExamTYT> _repository;
        public ExamTYTManager(IRepository<ExamTYT> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
