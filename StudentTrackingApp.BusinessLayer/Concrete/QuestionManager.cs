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
    public class QuestionManager : GenericService<Question>, IQuestionService
    {
        private readonly IRepository<Question> _repository;
        public QuestionManager(IRepository<Question> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
