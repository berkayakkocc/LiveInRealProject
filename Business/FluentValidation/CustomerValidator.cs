using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("You can enter a maximum of 50 " +
                "characters in the name field");
            RuleFor(x => x.City).NotEmpty().WithMessage("City field cannot be enmpty");
            RuleFor(x => x.City).MinimumLength(2).WithMessage("A minimum of 2 characters must be entered");
            
        }
    }
}
