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
    internal class StudentFeatureSeed : IEntityTypeConfiguration<StudentFeature>
    {
        public void Configure(EntityTypeBuilder<StudentFeature> builder)
        {
            builder.HasData(
                   new StudentFeature { Id = 1, Height = 150, Age = 10, StudentId = 1 },
                   new StudentFeature { Id = 2, Height = 140, Age = 12, StudentId = 2 });
        }
    }
}
