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
        [Key]
        public int ExamTYTId { get; set; }

        [StringLength(50)]
        public string ExamTYTName { get; set; }
        public DateTime ExamTYTDate { get; set; }
        public Byte TurkceDogru { get; set; }
        public Byte TurkceYanlis { get; set; }
        public Byte SosyalBilimlerDogru { get; set; }
        public Byte SosyalBilimlerYanlis { get; set; }
        public Byte MatematikDogru { get; set; }
        public Byte MatematikYanlis { get; set; }
        public Byte FenBilimleriDogru { get; set; }
        public Byte FenBilimleriYanlis { get; set; }


        //Relation
        public List<Student> Students { get; set; }
    }
}
