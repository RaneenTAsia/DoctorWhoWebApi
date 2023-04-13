using AutoMapper;
using DoctorWhoDomain.Entities;
using DoctorWhoDomain.Models;

namespace DoctorWho.Web.Profiles
{
    public class EpisodeProfile :Profile
    {
        public EpisodeProfile()
        {
            CreateMap<Episode, EpisodeDto>();
            CreateMap<EpisodeDto, Episode>();
            CreateMap<EpisodeForCreationDto, Episode>();
            CreateMap<Episode, EpisodeForCreationDto>();
        }
    }
}
