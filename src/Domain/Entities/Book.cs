using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Domain.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Category { get; set; }
        public string? Author { get; set; }
        public DateTime? YearPublished { get; set; }
        public double? Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImagePath { get; set; }        
        public string? Description { get; set; }
        public bool Available { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }

    }
}
