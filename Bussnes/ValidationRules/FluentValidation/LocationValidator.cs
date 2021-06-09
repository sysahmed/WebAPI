
using DataAccess.Entity;
using FluentValidation;

namespace Bussines.ValidationRules.FluentValidation
{
    public class PersonalValidator : AbstractValidator<Location>
    {
        public PersonalValidator()
        {
            RuleFor(p => p.LocationId).MinimumLength(1);
            RuleFor(p => p.LocationId).NotEmpty();
 
        }
    }
}
