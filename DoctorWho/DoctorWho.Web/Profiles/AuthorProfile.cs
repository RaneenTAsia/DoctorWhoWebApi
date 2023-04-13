using AutoMapper;
using DoctorWhoDomain.Entities;
using DoctorWhoDomain.Models;

namespace DoctorWho.Web.Profiles
{
    public class AuthorProfile :Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorForUpdateDto>();
            CreateMap<AuthorForUpdateDto, AuthorDto>();
            CreateMap<Author, AuthorDto>();
            CreateMap<AuthorForUpdateDto, Author>();
        }
    }
}
