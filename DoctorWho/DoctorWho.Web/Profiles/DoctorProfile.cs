using AutoMapper;
using DoctorWhoDomain;
using DoctorWhoDomain.Entities;
using DoctorWhoDomain.Models;

namespace DoctorWho.Web.Profiles
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, DoctorDto>();
            CreateMap<DoctorDto, Doctor>();
        }
    }
}
