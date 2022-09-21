using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.EntityLayer
{
    public class Todo
    {
        [Key]
        public int TodoId { get; set; }
        public DateTime TodoFirst { get; set; }
        public DateTime TodoFinish { get; set; }

        [StringLength(50)]
        public string TodoTitle { get; set; }

        [StringLength(500)]
        public string TodoContent { get; set; }
        public bool TodoStatus { get; set; }


        //Relation
        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}
