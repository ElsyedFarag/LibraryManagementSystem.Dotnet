using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Models
{
    public class Publisher
    {
        public Int16 Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
