using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.EntityLayer
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [StringLength(30)]
        public string BookName { get; set; }
        public Int16? BookPageCount { get; set; }
        public Int16 Revalsed { get; set; }

        //Relation
        public int? StudentId { get; set; }
        public Student Student { get; set; }
        public Byte? LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
