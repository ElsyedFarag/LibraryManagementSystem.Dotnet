using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Models
{
    public class Log
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public DateTime LoginTime { get; set; } = DateTime.Now;
    }
}
