using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Models
{
    public class BaseTransaction
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public Int16 UserId { get; set; }
        public DateTime TransactionTime { get; set; } = DateTime.Now;
        public bool IsCompleted { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
