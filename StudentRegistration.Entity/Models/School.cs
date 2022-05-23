using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Entity.Models
{
    public class School:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
