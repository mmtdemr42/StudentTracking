using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.EntityLayer
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [StringLength(100)]
        public string SubjectName { get; set; }


        //Relation
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
