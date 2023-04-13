using DoctorWhoDomain.Models;
using FluentValidation;

namespace DoctorWho.Web.Validators
{
    public class CompanionValidator :AbstractValidator<CompanionForCreationDto>
    {
        public CompanionValidator()
        {
            RuleFor(c => c.CompanionName)
                .MaximumLength(30);
            RuleFor(c => c.WhoPlayed)
                .MaximumLength(30);
        }
    }
}
