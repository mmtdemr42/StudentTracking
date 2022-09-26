using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.EntityLayer
{
    public class ExamTYT
    {
        public ExamTYT()
        {
            this.ExamTYTDate = DateTime.Now;
        }

        [Key]
        public int ExamTYTId { get; set; }

        [StringLength(50)]
        public string ExamTYTName { get; set; }
        public DateTime? ExamTYTDate { get; set; }
        public float TurkceDogru { get; set; }
        public float TurkceYanlis { get; set; }
        public float SosyalBilimlerDogru { get; set; }
        public float SosyalBilimlerYanlis { get; set; }
        public float MatematikDogru { get; set; }
        public float MatematikYanlis { get; set; }
        public float FenBilimleriDogru { get; set; }
        public float FenBilimleriYanlis { get; set; }


        //Relation
        public List<Student> Students { get; set; }
    }
}
