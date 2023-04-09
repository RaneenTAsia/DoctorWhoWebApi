using AutoMapper;
using DoctorWho.Db.Interfaces;
using DoctorWhoDomain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DoctorWho.Web.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;
        const int maxPageSize = 10;

        public DoctorsController(IDoctorRepository doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository ?? throw new ArgumentNullException(nameof(doctorRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DoctorDto>>> GetDoctors(int pageNumber =1 , int pageSize = 2)
        {
            if (pageSize >= 10)
            {
                pageSize = maxPageSize;
            }

            var (doctors, paginationMetadata) = await _doctorRepository.GetAllDoctorsAsync(pageNumber, pageSize);

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(_mapper.Map<IEnumerable<DoctorDto>>(doctors));    
        }
    }
}
