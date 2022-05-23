using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Entity.DTOs
{
    public class StudentDto:BaseDto
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public int SchooldId { get; set; }
    }
}
