using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.Common.Models.RequestModel;
using Bookstore.Domain.Entities;
using Bookstore.Domain.Enum;
using Bookstore.Infrastructure.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Infrastructure.Services
{
    public class BookService : IBookService
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;
        private readonly string _imageProductDirectory;

        public BookService(BookStoreDbContext dbContext, IConfiguration configuration, IWebHostEnvironment env)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _env = env ?? throw new ArgumentNullException(nameof(env));
            _imageProductDirectory = env.WebRootPath + @"\Images\Books";
        }
        public async Task<Book> AddBookAsync(AddBookRequestModel addBookRequestModel)
        {
            try
            {
                if (!Directory.Exists(_imageProductDirectory))
                {
                    Directory.CreateDirectory(_imageProductDirectory);
                }
                FileInfo _fileInfo = new FileInfo(addBookRequestModel.Image!.FileName);
                string filename = _fileInfo.Name.Replace(_fileInfo.Extension, "") + "_" + DateTime.Now.Ticks.ToString() + _fileInfo.Extension;
                var _filePath = $"{_imageProductDirectory}\\{filename}";

                using (var _fileStream = new FileStream(_filePath, FileMode.Create))
                {
                    await addBookRequestModel.Image.CopyToAsync(_fileStream);
                }
                string _urlPath = _filePath.Replace('\\', '/').Split("wwwroot").Last();
                string _imagePath = _filePath.Split("wwwroot").Last();



                var book = new Book() 
                { 
                    Title = addBookRequestModel.Title!,
                    Category = addBookRequestModel.Category!,
                    Author = addBookRequestModel.Author!,
                    YearPublished = addBookRequestModel.YearPublished,
                    Price = addBookRequestModel.Price,
                    Description = addBookRequestModel.Description!,
                    ImagePath = _imagePath,
                    ImageUrl = _urlPath,
                    
                    
                };

                if (book != null)
                {
                    var bookToAdd = await _dbContext.Books.AddAsync(book);
                    await _dbContext.SaveChangesAsync();
                    if (bookToAdd != null)
                    {
                        return book;
                    }                    
                }
                throw new Exception("Failed to add book");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException!.Message);
            }
        }

        public async Task<bool> DeleteBookAsync(Guid id)
        {
            try
            {
                var book = await GetBookByIdAsync(id);
                File.Delete(_env.WebRootPath + book.ImagePath);
                _dbContext.Books.Remove(book);
                await _dbContext.SaveChangesAsync();
                return true;
            }catch(Exception ex) { 
                throw new Exception(ex.Message); 
            }
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            Random rand = new Random();
            int skipper = rand.Next(0, _dbContext.Books.Where(x=> x.Available == true).Count());
            var books = await _dbContext.Books
                .Where(x=> x.Available == true)
                .OrderBy(x=>x.Id)
                .Skip(skipper)
                .ToListAsync();
            return books;
        }

        public async Task<List<Book>> GetAllBooksByPriceAscendingAsync()
        {
            var books = await _dbContext.Books
               .Where(x => x.Available == true)
               .OrderBy(x=> x.Price)
               .ToListAsync();
            return books;
        }

        public async Task<List<Book>> GetAllBooksByPriceDescendingAsync()
        {
            var books = await _dbContext.Books
               .Where(x => x.Available == true)
               .OrderByDescending(x => x.Price)
               .ToListAsync();
            return books;
        }

        public async Task<Book> GetBookByIdAsync(Guid id)
        {
            try
            {
                var book = await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == id); 
                if (book == null)
                {
                    throw new Exception("Book does not exist.");
                }
                return book;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Book>> GetBooksByCategoryAsync(string category)
        {
            try
            {
                var booksByCategory = await _dbContext.Books
                    .Where(x => x.Category == category && x.Available == true)
                    .ToListAsync();                

                return booksByCategory;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Book> PurchaseBookAsync(Guid bId, Guid uId)
        {
            try
            {
                var book = await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == bId);
                if (book == null)
                {
                    throw new Exception("No book found");
                }

                book.UserId = uId;
                book.Available = false;
                await _dbContext.SaveChangesAsync();
                return book;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Book> UpdateBookAsync(Guid id,UpdateBookRequestModel updateBookRequestModel)
        {
            try
            {
                var book = await GetBookByIdAsync(id);

                if (book == null)
                {
                    throw new Exception("User Not Found");
                }
                book.Title = string.IsNullOrEmpty(updateBookRequestModel.Title) ? book.Title : updateBookRequestModel.Title;
                book.Category = string.IsNullOrEmpty(updateBookRequestModel.Category) ? book.Category : updateBookRequestModel.Category;
                book.Author = string.IsNullOrEmpty(updateBookRequestModel.Author) ? book.Author : updateBookRequestModel.Author;
                book.YearPublished = updateBookRequestModel.YearPublished==null ? book.YearPublished : updateBookRequestModel.YearPublished;
                book.Price = updateBookRequestModel.Price==null ? book.Price : updateBookRequestModel.Price;

                book.Description = string.IsNullOrEmpty(updateBookRequestModel.Description) ? book.Description : updateBookRequestModel.Description;

                if (updateBookRequestModel.Image != null)
                {
                    if (!Directory.Exists(_imageProductDirectory))
                    {
                        Directory.CreateDirectory(_imageProductDirectory);
                    }
                    FileInfo _fileInfo = new FileInfo(updateBookRequestModel.Image!.FileName);
                    string filename = _fileInfo.Name.Replace(_fileInfo.Extension, "") + "_" + DateTime.Now.Ticks.ToString() + _fileInfo.Extension;
                    var _filePath = $"{_imageProductDirectory}\\{filename}";

                    using (var _fileStream = new FileStream(_filePath, FileMode.Create))
                    {
                        await updateBookRequestModel.Image.CopyToAsync(_fileStream);
                    }
                    string _urlPath = _filePath.Replace('\\', '/').Split("wwwroot").Last();
                    string _imagePath = _filePath.Split("wwwroot").Last();
                    book.ImagePath = _imagePath;
                    book.ImageUrl = _urlPath;
                }
                book.ImagePath = book.ImagePath;
                book.ImageUrl = book.ImageUrl;
               

                await _dbContext.SaveChangesAsync();

                return book;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
