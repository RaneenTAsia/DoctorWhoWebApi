using DoctorWhoDomain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Validators
{
    public class DoctorsValidator : AbstractValidator<DoctorDto>
    {
        public DoctorsValidator() 
        {
            RuleFor(doctor => doctor.DoctorName)
                .NotEmpty()
                .MaximumLength(30);

            RuleFor(doctor => doctor.LastEpisodeDate)
                .GreaterThanOrEqualTo(doctor => doctor.FirstEpisodeDate)
                .When(doctor => doctor.FirstEpisodeDate.HasValue && doctor.LastEpisodeDate.HasValue)
                .WithMessage("The last episode date cannot be before the the first episode date");

            RuleFor(doctor => doctor.LastEpisodeDate)
                .NotEmpty()
                .When(doctor => (!doctor.FirstEpisodeDate.HasValue));
        }
    }
}
