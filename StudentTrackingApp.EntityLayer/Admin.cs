using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracking.EntityLayer
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [StringLength(20)]
        public string AdminName { get; set; }

        [StringLength(20)]
        public string AdminSurname { get; set; }


        [StringLength(20)]
        public string AdminEmail { get; set; }

        [StringLength(20)]
        public string AdminPassword { get; set; }

        [StringLength(1)]
        public string AdminRole { get; set; }
    }
}
