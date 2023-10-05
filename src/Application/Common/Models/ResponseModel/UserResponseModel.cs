using Bookstore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Application.Common.Models.ResponseModel
{
    public class UserResponseModel
    {
        public Response Response { get; set; } = new Response();
        public User User { get; set; } = new User();
    }
}
