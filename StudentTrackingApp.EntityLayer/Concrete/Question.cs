using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.EntityLayer
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int QuestionCount { get; set; }
        public DateTime QuestionDate { get; set; }


        //Relation
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public Byte LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
