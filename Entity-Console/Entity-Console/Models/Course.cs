using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Console.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }

        public int StudentId { get; set; }
    }
}
