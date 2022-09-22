using StudentTracking.DataAccessLayer.Abstract;
using StudentTracking.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.DataAccessLayer.Concrete.Repository
{
    public class EfLessonDal: GenericRepository<Lesson>, ILessonDal
    {
    }
}
