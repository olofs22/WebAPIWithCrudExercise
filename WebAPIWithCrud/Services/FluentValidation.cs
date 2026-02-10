using FluentValidation;
using WebAPIWithCrud.Models;

namespace WebAPIWithCrud.Services
{
    public class CreateUserRequestValidator : AbstractValidator<Items>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(1);

            RuleFor(x => x.Description)
                .MaximumLength(10);
        }
    }
}
