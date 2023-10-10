using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.Common.Models.RequestModel;
using Bookstore.Application.Common.Models.ResponseModel;
using Bookstore.Infrastructure.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet("getAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookService.GetAllBooksAsync();
            return Ok( new BookListResponseModel
            {
                Response = new Response
                {
                    StatusCode = 200,
                    Message = "Successfully Fetched Books"
                },
                Books = books
            }
            );
        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet("getAllBooksByPriceAscending")]
        public async Task<IActionResult> GetAllBooksOrderByPriceAscending()
        {
            var books = await _bookService.GetAllBooksByPriceAscendingAsync();
            return Ok(new BookListResponseModel
            {
                Response = new Response
                {
                    StatusCode = 200,
                    Message = "Successfully Fetched Books"
                },
                Books = books
            }
            );
        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet("getAllBooksByPriceDescending")]
        public async Task<IActionResult> GetAllBooksOrderByPriceDescending()
        {
            var books = await _bookService.GetAllBooksByPriceDescendingAsync();
            return Ok(new BookListResponseModel
            {
                Response = new Response
                {
                    StatusCode = 200,
                    Message = "Successfully Fetched Books"
                },
                Books = books
            }
            );
        }

        [Authorize(Roles = "User,Admin")]
        [HttpGet("getBookById/{id}")]
        public async Task<IActionResult> GetBookById([FromRoute]Guid id)
        {
            var book = await _bookService.GetBookByIdAsync(id);

            return Ok(new BookResponseModel
            {
                Response = new Response
                {
                    StatusCode = 200,
                    Message = $"Fetched Book with id {id}"
                },
                Book = book
            });
        }
        [Authorize(Roles = "Admin")]
        [HttpPost("addBook")]
        public async Task<IActionResult> AddBook([FromForm]AddBookRequestModel addBookRequestModel)
        {
            var book = await _bookService.AddBookAsync(addBookRequestModel);
            return Ok(new Response
            {
                StatusCode = 201,
                Message = "Book added"
            });
        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet("booksByCategory/{category}")]
        public async Task<IActionResult> GetBooksByCategory([FromRoute]string category)
        {
            var books = await _bookService.GetBooksByCategoryAsync(category);

            return Ok(new BookListResponseModel
            {
                Response = new Response
                {
                    StatusCode = 200,
                    Message = $"Book fetched of category {category}"
                },
                Books = books
            });
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("updateBook/{id}")]
        public async Task<IActionResult> UpdateBook([FromRoute] Guid id,[FromForm] UpdateBookRequestModel updateBookRequestModel)
        {
            await _bookService.UpdateBookAsync(id, updateBookRequestModel);
            return Ok(new Response
            {
                StatusCode=200,
                Message = "Book updated"
            });
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("deleteBook/{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute]Guid id)
        {
            await _bookService.DeleteBookAsync(id);
            return Ok(new Response
            {
                StatusCode=200,
                Message = $"Book with id {id} deleted."
            });
        }

        [Authorize(Roles = "User")]
        [HttpPost("purchaseBook/{bId}/{uId}")]
        public async Task<IActionResult> PurchaseBook([FromRoute]Guid bId, [FromRoute]Guid uId)
        {
            await _bookService.PurchaseBookAsync(bId, uId);

            return Ok(new Response
            {
                StatusCode = 200,
                Message = "Purchase Successfull"
            });
        }

        [Authorize(Roles ="User")]
        [HttpGet("purchasedBook/{uId}")]
        public async Task<IActionResult> PurchasedBook([FromRoute]Guid uId)
        {
           var books =  await _bookService.GetPurchasedBookAsync(uId);

            return Ok(new BookListResponseModel
            {
                Response = new Response
                {
                    StatusCode = 200,
                    Message = $"Purchased book fetched for user id {uId}"
                },
                Books = books
            });
        }
    }
}
