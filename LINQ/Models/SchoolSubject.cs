using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    public class SchoolSubject
    {
        [Key]
        public int subjectID { get; set; }
        [Required]
        public string subjectName { get; set; }

        public int teacherID { get; set; }
        public Teacher Teacher { get; set; }


        public ICollection<StudentSubject> StudSubjects { get; set; }
    }
}
