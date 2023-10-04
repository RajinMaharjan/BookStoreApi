using Bookstore.Application.Common.Models.RequestModel;
using Bookstore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Application.Common.Interfaces
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(Guid id);
        Task<List<Book>> GetBooksByCategoryAsync(string category);
        Task<Book> AddBookAsync(AddBookRequestModel addBookRequestModel);
        Task<Book> UpdateBookAsync();
        Task DeleteBookAsync(Guid id);
        
    }
}
