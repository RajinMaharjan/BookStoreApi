using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Application.Common.Models.ResponseModel
{
    public class ApiError
    {
        public string? Message { get; set; }

        public string? Status { get; set; }

        public ApiError() { }

        public ApiError(ModelStateDictionary modelState)
        {
            var errors = modelState?.Keys.SelectMany(key => modelState[key]!.Errors.Select(x => x.ErrorMessage));
            Message = string.Join(Environment.NewLine, errors!);
        }
    }
}
