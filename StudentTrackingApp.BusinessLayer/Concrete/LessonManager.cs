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
    public class LessonManager : GenericService<Lesson>, ILessonService
    {
        private readonly IRepository<Lesson> _repository;
        public LessonManager(IRepository<Lesson> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
