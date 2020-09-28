using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.fluentValidation
{
   public class productValidation:AbstractValidator<Product>
    {
        public productValidation()
        {
            RuleFor(x => x.price).NotEmpty();
            RuleFor(x => x.count).GreaterThan(1);
            RuleFor(x => x.productName).NotEmpty();
            RuleFor(x => x.categoryId).NotNull();
            RuleFor(x => x.productName).MaximumLength(70);
            RuleFor(x => x.productName).MinimumLength(4);

        }
    }
}
