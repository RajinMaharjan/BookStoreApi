using Azure;
using Bookstore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Application.Common.Models.ResponseModel
{
    public class BookResponseModel
    {
        public Response Response { get; set; } = new Response();
        public Book Book { get; set; } = new Book();
    }
}
