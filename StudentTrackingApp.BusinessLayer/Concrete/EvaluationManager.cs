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
    public class EvaluationManager : GenericService<Evaluation>, IEvaluationService
    {
        private readonly IRepository<Evaluation> _repository;

        public EvaluationManager(IRepository<Evaluation> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
