using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Application.Common.Models.RequestModel
{
    public class UpdateBookRequestModel
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public DateTime YearPublished { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
