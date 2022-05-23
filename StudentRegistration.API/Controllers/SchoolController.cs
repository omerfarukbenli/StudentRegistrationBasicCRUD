using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Business;
using StudentRegistration.Entity.DTOs;
using StudentRegistration.Entity.Models;

namespace StudentRegistration.API.Controllers
{
   
    public class SchoolController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<School> _service; //controllerlar servicleri bilir, productsevice'i alınca ıservice'e gerek yok

        public SchoolController(IMapper mapper, IService<School> service)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var schools = await _service.GetAllAsync();
            var schoolsDtos = _mapper.Map<List<SchoolDto>>(schools.ToList());
            return CreateActionResult(CustomResponseDto<List<SchoolDto>>.Success(200, schoolsDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var school = await _service.GetByIdAsync(id);
            var schoolDto = _mapper.Map<SchoolDto>(school);
            return CreateActionResult(CustomResponseDto<SchoolDto>.Success(200, schoolDto));
        }
        [HttpPost]
        public async Task<IActionResult> Save(SchoolDto schoolDto)
        {
            var schools = await _service.AddAsync(_mapper.Map<School>(schoolDto));
            var schoolDtos = _mapper.Map<SchoolDto>(schools);
            return CreateActionResult(CustomResponseDto<SchoolDto>.Success(201, schoolDto)); //201 created //oluşturuldu
        }
        [HttpPut]
        public async Task<IActionResult> Update(SchoolDto schoolDto) //güncellemede bir şey dönmüyor, no content //product dto yu kullandığımız için createdate gelecek onun gelmesini istemiyorsak productupdatedto kullanabiliriz
        {
            await _service.UpdateAsync(_mapper.Map<School>(schoolDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204)); //204 nocontent
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var school = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(school);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
