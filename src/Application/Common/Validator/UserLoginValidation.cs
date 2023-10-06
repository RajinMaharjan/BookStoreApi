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
    public class UserLoginValidation:AbstractValidator<UserLoginRequestModel>
    {
        public UserLoginValidation()
        {
            RuleFor(x => x.Email.Trim().ToLower())
               .NotNull().NotEmpty().WithMessage("Enter your email address.")
               .MaximumLength(100).WithMessage("Email cannot be longer than 100 words")
               .Must(email => ValidEmail(email)).WithMessage("Invalid email format.");

            RuleFor(x => x.Password)
                .NotNull().NotEmpty().WithMessage("Enter your password.")
                .Length(8, 20).Must(password => ValidPassword(password))
                .WithMessage("Password should contain at least one lowercase, one uppercase, one digit and one special character and length must be greater than 8.");
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
