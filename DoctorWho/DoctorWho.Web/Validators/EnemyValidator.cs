using DoctorWhoDomain.Models;
using FluentValidation;

namespace DoctorWho.Web.Validators
{
    public class EnemyValidator :AbstractValidator<EnemyForCreationDto>
    {
        public EnemyValidator()
        {
            RuleFor(e => e.EnemyName)
                .MaximumLength(30);
            RuleFor(e => e.Description)
                .MaximumLength(300);
        }
    }
}
