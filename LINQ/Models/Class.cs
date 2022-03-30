
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ.Models
{
    public class Class
    {

        [Key]
        public int classID { get; set; }
        [Required]
        public string className { get; set; }


        public ICollection<Student> Students { get; set; }
    }
}
