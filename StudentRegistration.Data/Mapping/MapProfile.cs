using AutoMapper;
using StudentRegistration.Entity.DTOs;
using StudentRegistration.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration.Data.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<School, SchoolDto>().ReverseMap(); //product'ı productdto'ya dönüştürüyor, bu 3 ü reverse olan temel dtolar
            CreateMap<Student, StudentDto>().ReverseMap(); //reverse tersi yapmak demek
            CreateMap<StudentFeature, StudentFeatureDto>().ReverseMap();
            
        }
    }
}
