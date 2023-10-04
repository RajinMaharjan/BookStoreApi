using Bookstore.Infrastructure.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Authorize(Roles = "User")]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookStoreDbContext _dbContext;
        public BookController(BookStoreDbContext bookStoreDbContext)
        {
            _dbContext = bookStoreDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _dbContext.Books.ToListAsync();
            return Ok(books);
        }
    }
}
