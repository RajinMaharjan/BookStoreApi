using Bookstore.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber {  get; set; }
        public string PhotoUrl {  get; set; }
        public Role Role { get; set; } 
        public ICollection<Book> Books { get; set; }

    }
}
