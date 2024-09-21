using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Models
{
    public class Category
    {
        public Byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
