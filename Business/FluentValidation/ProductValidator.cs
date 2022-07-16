using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("You can enter a maximum of 3 " +
                "characters in the name field");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Price field connot be empty");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stock field connot be empty");

        }
    }
}
