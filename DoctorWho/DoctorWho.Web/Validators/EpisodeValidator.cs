using DoctorWhoDomain.Models;
using FluentValidation;

namespace DoctorWho.Web.Validators
{
    public class EpisodeValidator :AbstractValidator<EpisodeForCreationDto>
    {
        public EpisodeValidator()
        {
            RuleFor(e => e.AuthorId)
                .NotEmpty()
                .WithMessage("AuthorId must be provided");

            RuleFor(e => e.DoctorId)
                .NotEmpty()
                .WithMessage("DoctorId is required");

            RuleFor(e => e.SeriesNumber)
                .GreaterThan(0)
                .WithMessage("SeriesNumber must be greater than 0");

            RuleFor(e => e.EpisodeNumber)
                .GreaterThan(0)
                .WithMessage("The episode must be greater than 0");

        }   
    }
}
