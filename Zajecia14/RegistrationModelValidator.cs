using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia14
{
    public class RegistrationModelValidator : AbstractValidator<RegistrationModel>
    {
        public RegistrationModelValidator()
        {
            this.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(x => x.Email)
                .NotNull()
                .WithMessage("Twój email nie może być pusty \n")
                .EmailAddress()
                .WithMessage("Podaj prawidłowy adres email \n");

            RuleFor(x => x.Password)
                .NotNull()
                .WithMessage("Twoje hasło nie może być puste! \n")
                .MinimumLength(8)
                .WithMessage("Twoje hasło musi zawierać 8 znaków \n")
                .MaximumLength(12)
                .WithMessage("Twoje hasło nie może być dłuższe niż 12 znaków \n");

            RuleFor(x => x.Accept)
                .Must(x => x)
                .WithMessage("Musisz zaznaczyć pole powyżej \n");

        }

    }
}
