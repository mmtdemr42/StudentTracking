using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.EntityLayer
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [StringLength(20)]
        public string TeacherName { get; set; }

        [StringLength(20)]
        public string TeacherSurname { get; set; }
        public Byte LessonId { get; set; }

        [StringLength(30)]
        public string TeacherEMail { get; set; }

        [StringLength(20)]
        public string Password { get; set; }
    }
}
