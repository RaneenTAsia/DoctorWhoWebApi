using AutoMapper;
using DoctorWhoDomain.Entities;
using DoctorWhoDomain.Models;

namespace DoctorWho.Web.Profiles
{
    public class CompanionProfile :Profile
    {
        public CompanionProfile()
        {
            CreateMap<Companion, CompanionForCreationDto>();
            CreateMap<CompanionForCreationDto, Companion>();
            CreateMap<Companion, CompanionDto>();
        }
    }
}
