using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.EntityLayer
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public int StudentNumber { get; set; }
        public int ClassId { get; set; }

        [StringLength(20)]
        public string StudentName { get; set; }

        [StringLength(20)]
        public string StudentSurname { get; set; }

        public bool StudentGender { get; set; }

        [StringLength(30)]
        public string StudentEMail { get; set; }

        [StringLength(20)]
        public string StudentPassword { get; set; }
        public bool StudentStatus { get; set; }

    }
}
