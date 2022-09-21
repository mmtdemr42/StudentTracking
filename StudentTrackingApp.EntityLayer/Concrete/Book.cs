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
        public Int16 BookPageCount { get; set; }

        //Relation
        public List<Student> Students { get; set; }
    }
}
