using asp.net_core_demo.Dto;
using FluentValidation;

namespace asp.net_core_demo.Validators
{
    public class UserValidator : AbstractValidator<UserRegisterDTO>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).MinimumLength(3);
            RuleFor(x => x.Age).GreaterThan(20);
            RuleFor(x => x.Address).MaximumLength(20);
        }
    }
}
