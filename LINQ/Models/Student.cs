using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ.Models
{
    public class Student
    {

        [Key]
        public int studentID { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }

        public int classID { get; set; }
        public Class Classes { get; set; }
        public ICollection<StudentSubject> StudSubjects { get; set; }
    }
}
