using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
   public class Teacher
    {
        [Key]
        public int teacherID { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }



        public ICollection<SchoolSubject> SchoolSubjects { get; set; }
    }
}
