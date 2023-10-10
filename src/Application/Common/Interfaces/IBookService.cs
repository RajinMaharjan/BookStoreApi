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
        Task<List<Book>> GetAllBooksByPriceAscendingAsync();
        Task<List<Book>> GetAllBooksByPriceDescendingAsync();
        Task<Book> GetBookByIdAsync(Guid id);
        Task<List<Book>> GetBooksByCategoryAsync(string category);
        Task<Book> AddBookAsync(AddBookRequestModel addBookRequestModel);
        Task<Book> UpdateBookAsync(Guid id,UpdateBookRequestModel updateBookRequestModel);
        Task<bool> DeleteBookAsync(Guid id);
        Task<Book> PurchaseBookAsync(Guid bId, Guid uId);
        Task<List<Book>> GetPurchasedBookAsync(Guid uId);
        
    }
}
