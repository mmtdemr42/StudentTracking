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

        //Relation
        public List<Book> Books { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }

        public List<Evaluation> Evaluations { get; set; }

        public List<ExamTYT> ExamTYTs { get; set; }


        public List<Lesson> Lessons { get; set; }


        public List<Question> Questions { get; set; }


        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }


        public List<Todo> Todos { get; set; }
    }
}
