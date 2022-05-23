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
    internal class SchoolSeed : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {                       
                builder.HasData(
                    new School { Id = 1, Name = "Lise" },
                    new School { Id = 2, Name = "Ortaokul" },
                    new School { Id = 3, Name = "İlkokul" }
                    );
            }
        }
    }

