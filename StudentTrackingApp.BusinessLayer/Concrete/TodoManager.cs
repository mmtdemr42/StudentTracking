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
    public class TodoManager : GenericService<Todo>, ITodoService
    {
        private readonly IRepository<Todo> _repository;

        public TodoManager(IRepository<Todo> repository) : base(repository)
        {
        }
    }
}
