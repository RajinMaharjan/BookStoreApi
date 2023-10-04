using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.Common.Models.RequestModel;
using Bookstore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Infrastructure.Services
{
    public class BookService : IBookService
    {
        public Task<Book> AddBookAsync(AddBookRequestModel addBookRequestModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAllBooksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetBooksByCategoryAsync(string category)
        {
            throw new NotImplementedException();
        }

        public Task<Book> UpdateBookAsync()
        {
            throw new NotImplementedException();
        }
    }
}
