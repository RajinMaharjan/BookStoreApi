using Bookstore.Domain.Entities;
using Bookstore.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Infrastructure.Persistence.Seed
{
    public class SeedDb
    {
        private static Guid Guid = Guid.NewGuid();
        public static void SeedUser(ModelBuilder modelBuilder)
        {
            //for seeding
            var userList = new List<User>()
             {
            new User()
            {
                Id = Guid,
                FirstName = "Rajin",
                LastName = "Maharjan",
                Email = "rajin@gmail.com",
                PasswordHash = "R@r12345",
                Role = Role.Admin,
                PhoneNumber = "1234567800",
            },
            new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Gagan",
                LastName = "Maharjan",
                Email = "gagan@gmail.com",
                PasswordHash = "G@g12345",
                Role = Role.User,
                PhoneNumber = "1134567890",
            },
            new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Milan",
                LastName = "Maharjan",
                Email = "milann@gmail.com",
                PasswordHash = "M@m12345",
                Role = Role.User,
                PhoneNumber = "1234567890",
            }
            };

            //seed to db
            modelBuilder.Entity<User>().HasData(userList);
        }
        public static void SeedBook(ModelBuilder modelBuilder)
        {
            var bookList = new List<Book>()
            {
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Author = "A",
                    Title = "A",
                    Category = "A",
                    Price = 1099.99,
                    ImageUrl = "A",
                    Description = "A",
                    UserId = Guid,
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Author = "B",
                    Title = "B",
                    Category = "B",
                    Price = 1199.99,
                    ImageUrl = "B",
                    Description = "B",
                    UserId = Guid,
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Author = "C",
                    Title = "C",
                    Category = "C",
                    Price = 1299.99,
                    ImageUrl = "C",
                    Description = "C",
                    UserId = Guid,
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Author = "D",
                    Title = "D",
                    Category = "D",
                    Price = 1399.99,
                    ImageUrl = "D",
                    Description = "D",
                    UserId = Guid,
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Author = "E",
                    Title = "E",
                    Category = "E",
                    Price = 1499.99,
                    ImageUrl = "E",
                    Description = "E",
                    UserId = Guid,
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Author = "F",
                    Title = "F",
                    Category = "F",
                    Price = 1599.99,
                    ImageUrl = "F",
                    Description = "F",
                    UserId = Guid,
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Author = "G",
                    Title = "G",
                    Category = "G",
                    Price = 1699.99,
                    ImageUrl = "G",
                    Description = "G",
                    UserId = Guid,
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Author = "H",
                    Title = "H",
                    Category = "H",
                    Price = 1699.99,
                    ImageUrl = "H",
                    Description = "H",
                    UserId = Guid,
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Author = "I",
                    Title = "I",
                    Category = "I",
                    Price = 1799.99,
                    ImageUrl = "I",
                    Description = "I",
                    UserId = Guid,
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Author = "J",
                    Title = "J",
                    Category = "J",
                    Price = 1899.99,
                    ImageUrl = "J",
                    Description = "J",
                    UserId = Guid,
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Author = "K",
                    Title = "A",
                    Category = "K",
                    Price = 1999.99,
                    ImageUrl = "K",
                    Description = "K",
                    UserId = Guid,
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Author = "L",
                    Title = "L",
                    Category = "L",
                    Price = 2099.99, 
                    ImageUrl = "L",
                    Description = "L",
                    UserId = Guid,
                },
            };
            modelBuilder.Entity<Book>().HasData(bookList);
        }
    }
}
