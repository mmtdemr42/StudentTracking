using StudentTracking.BusinessLayer.Abstract.IService;
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
    public class AdminManager : GenericService<Admin>, IAdminService
    {
        private readonly IRepository<Admin> _repository;
        public AdminManager(IRepository<Admin> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
