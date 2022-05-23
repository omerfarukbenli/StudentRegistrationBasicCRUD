using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Entity.DTOs
{
    public class StudentFeatureDto
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int StudentId { get; set; }
    }
}
