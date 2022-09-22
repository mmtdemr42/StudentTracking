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
    public class ContactManager : GenericService<Contact>, IContactService
    {
        private readonly IRepository<Contact> _repository;
        public ContactManager(IRepository<Contact> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
