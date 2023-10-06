using Bookstore.Application.Common.Models.RequestModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bookstore.Application.Common.Validator
{
    public class UserRegisterValidation:AbstractValidator<UserRegisterRequestModel>
    {
        public UserRegisterValidation() 
        {
            RuleFor(x => x.FirstName)
               .NotNull().NotEmpty().WithMessage("Enter your first name.")
               .MaximumLength(100).WithMessage("First Name cannot be longer than 100 words.");

            RuleFor(x => x.LastName)
                .NotNull().NotEmpty().WithMessage("Enter your last name.")
                .MaximumLength(100).WithMessage("First Name cannot be longer than 100 words.");

            RuleFor(x => x.Email.Trim().ToLower())
                .NotNull().NotEmpty().WithMessage("Enter your email address.")
                .MaximumLength(100).WithMessage("Email cannot be longer than 100 words")
                .Must(email => ValidEmail(email)).WithMessage("Invalid email format.");

            RuleFor(x => x.PhoneNumber.Trim())
                .NotNull().NotEmpty().WithMessage("Enter your phone number.")
                .Length(10).WithMessage("Phone number must be 10 digit.");

            RuleFor(x => x.Password)
                .NotNull().NotEmpty().WithMessage("Enter your password.")
                .Length(8, 20).Must(password => ValidPassword(password))
                .WithMessage("Password should contain at least one lowercase, one uppercase, one digit and one special character and length must be greater than 8.");

            RuleFor(x => x.ConfirmPassword)
               .NotNull().NotEmpty().WithMessage("Enter your password again.")
               .Length(8, 20).Must(password => ValidPassword(password))
               .WithMessage("Password should contain at least one lowercase, one uppercase, one digit and one special character and length must be greater than 8.")
               .Equal(x => x.Password).WithMessage("Password does not match");
        }
        public static bool ValidEmail(string email)
        {
            const string emailRegex =
                @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return new Regex(emailRegex).IsMatch(email);
        }

        public static bool ValidPassword(string password)
        {
            var lowercase = new Regex("[a-z]+");
            var uppercase = new Regex("[A-Z]+");
            var digit = new Regex("(\\d)+");
            var symbol = new Regex("(\\W)+");

            return lowercase.IsMatch(password) && uppercase.IsMatch(password) && digit.IsMatch(password) && symbol.IsMatch(password);
        }
    }
}
