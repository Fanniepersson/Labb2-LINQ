using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    public class StudentSubject
    {

        public int id { get; set; }
        public int studentID { get; set; }

        public int SchoolSubjectssubjectID { get; set; }


        public SchoolSubject SchoolSubjects { get; set; }
        public Student Students { get; set; }
    }
}
