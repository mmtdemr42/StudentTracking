using StudentTracking.DataAccessLayer.Abstract;
using StudentTracking.DataAccessLayer.Concrete.Repository;
using StudentTracking.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.DataAccessLayer.EntityFramework
{
    public class EfSubjectDal: GenericRepository<Subject>, ISubjectDal
    {
    }
}
