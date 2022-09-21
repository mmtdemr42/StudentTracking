using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.EntityLayer
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        [StringLength(5)]
        public string ClassName { get; set; }

        //Relation

        public List<Student> Students { get; set; }
    }
}

