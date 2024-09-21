using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LibraryManagementSystem.Entities.Models
{
    public class User : IdentityUser
    {
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; } = null!;

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; } = null!;
        public ICollection<Log> Logs { get; set; } = new List<Log>();
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public ICollection<TransactionBuy> TransactionBuys { get; set; } = new List<TransactionBuy>();
        public ICollection<TransactionBorrow> TransactionBorrows { get; set; } = new List<TransactionBorrow>();
    }
}
