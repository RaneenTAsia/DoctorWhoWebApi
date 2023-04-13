using DoctorWhoDomain.Models;
using FluentValidation;

namespace DoctorWho.Web.Validators
{
    public class AuthorValidator :AbstractValidator<AuthorForUpdateDto>
    {
        public AuthorValidator()
        {
            RuleFor(a => a.AuthorName)
                .NotEmpty()
                .MaximumLength(30);
        }
    }
}
