using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.EntityLayer
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        [StringLength(50)]
        public string AboutTitle { get; set; }
        public string AboutContent { get; set; }

        [StringLength(100)]
        public string AboutImage { get; set; }
    }
}
