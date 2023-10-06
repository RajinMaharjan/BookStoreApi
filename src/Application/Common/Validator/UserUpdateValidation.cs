using Bookstore.Application.Common.Models.RequestModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Application.Common.Validator
{
    public class UserUpdateValidation:AbstractValidator<UserUpdateRequestModel>
    {
        public UserUpdateValidation() 
        {
            RuleFor(x => x.FirstName)
              .NotNull().NotEmpty().WithMessage("Enter your first name.")
              .MaximumLength(100).WithMessage("First Name cannot be longer than 100 words.");

            RuleFor(x => x.LastName)
                .NotNull().NotEmpty().WithMessage("Enter your last name.")
                .MaximumLength(100).WithMessage("First Name cannot be longer than 100 words.");
        }
    }
}
