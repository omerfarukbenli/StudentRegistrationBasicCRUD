using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Entity.Models
{
    public class Student : BaseEntity
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public int SchooldId { get; set; }
        public School School { get; set; }
        public StudentFeature StudentFeature { get; set; }

    }
}
