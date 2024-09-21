using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Models
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public Byte Rate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Book Book { get; set; }
        public Guid BookId { get; set; }
    }
}
