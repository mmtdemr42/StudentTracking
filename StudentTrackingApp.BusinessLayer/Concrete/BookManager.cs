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
    public class BookManager : GenericService<Book>, IBookSErvice
    {
        private readonly IRepository<Book> _repository;
        public BookManager(IRepository<Book> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
