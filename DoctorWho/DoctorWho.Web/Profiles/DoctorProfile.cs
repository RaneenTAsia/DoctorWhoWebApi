using AutoMapper;
using DoctorWhoDomain;

namespace DoctorWho.Web.Profiles
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<DoctorWhoDomain.Entities.Doctor, DoctorWhoDomain.Models.DoctorDto>();
        }
    }
}
