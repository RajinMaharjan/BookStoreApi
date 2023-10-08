using Bookstore.Domain.Entities;
using Bookstore.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Infrastructure.Persistence
{
    public class BookStoreDbContext : DbContext
    {

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

            SeedDb.SeedUser(modelBuilder);
           // SeedDb.SeedBook(modelBuilder);         

        }
    }
}
