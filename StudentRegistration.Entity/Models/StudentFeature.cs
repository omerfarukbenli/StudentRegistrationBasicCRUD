using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Entity.Models
{
    public class StudentFeature
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
