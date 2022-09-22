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
    public class AboutManager : GenericService<About>, IAboutService
    {
        private readonly IRepository<About> _repository;
        public AboutManager(IRepository<About> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
