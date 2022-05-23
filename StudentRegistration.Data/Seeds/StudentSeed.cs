using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentRegistration.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Data.Seeds
{
    internal class StudentSeed : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                     new Student { Id = 1, FirsName = "ahmet", LastName = "veli", SchooldId = 1, CreatedDate = DateTime.Now },
                     new Student { Id = 2, FirsName = "ali", LastName = "erdal", SchooldId = 2, CreatedDate = DateTime.Now },
                      new Student { Id = 3, FirsName = "murat", LastName = "vural", SchooldId = 1, CreatedDate = DateTime.Now },
                       new Student { Id = 4, FirsName = "volkan", LastName = "arda", SchooldId = 3, CreatedDate = DateTime.Now },
                        new Student { Id = 5, FirsName = "atakan", LastName = "dural", SchooldId = 2, CreatedDate = DateTime.Now }
                     );
        }
    }
}

