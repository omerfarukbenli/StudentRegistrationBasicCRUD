using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentRegistration.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Data.Configurations
{
    internal class StudentFeatureConfiguration : IEntityTypeConfiguration<StudentFeature>
    {
        public void Configure(EntityTypeBuilder<StudentFeature> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Height).IsRequired();
            builder.HasOne(x => x.Student).WithOne(x => x.StudentFeature).HasForeignKey<StudentFeature>(x => x.StudentId);
            //bire bir ilişki
        }
    }
}
