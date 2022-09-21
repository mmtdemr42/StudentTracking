using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.EntityLayer
{
    public class Evaluation
    {
        [Key]
        public int EvaluationId { get; set; }
        [StringLength(50)]
        public string EvaluationTitle { get; set; }

        [StringLength(1000)]
        public string EvaluationContent { get; set; }
        public DateTime EvaluationDate { get; set; }
        public bool EvaluationStatus { get; set; }

        //Relation
        public int StudentId { get; set; }
        public Student Student { get; set; }


        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
