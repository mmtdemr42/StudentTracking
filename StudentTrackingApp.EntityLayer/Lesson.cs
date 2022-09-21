using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.EntityLayer
{
    public class Lesson
    {
        [Key]
        public Byte LessonId { get; set; }
        [StringLength(20)]
        public string LessonName { get; set; }
    }
}
