using AutoMapper;
using DoctorWhoDomain.Entities;
using DoctorWhoDomain.Models;

namespace DoctorWho.Web.Profiles
{
    public class EnemyProfile :Profile
    {
        public EnemyProfile()
        {
            CreateMap<Enemy, EnemyForCreationDto>();
            CreateMap<EnemyForCreationDto, Enemy>();
            CreateMap<Enemy, EnemyDto>();
        }
    }
}
