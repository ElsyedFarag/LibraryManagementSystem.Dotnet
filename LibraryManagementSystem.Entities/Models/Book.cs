using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int Year { get; set; }
        public int CopiesAvailable { get; set; }
        public decimal Price { get; set; }
        public bool IsForBorrow { get; set; }
        public bool IsForSale { get; set; }
        public Publisher Publisher { get; set; }
        public Int16 PublisherId { get; set; }
        public Byte CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<TransactionBorrow> TransactionBorrows { get; set; } = new List<TransactionBorrow>();
        public ICollection<TransactionBuy> TransactionBuys { get; set; } = new List<TransactionBuy>();
        public ICollection<Author> Authors { get; set; } = new List<Author>();
        public ICollection<Book> Books { get; set; } = new List<Book>();
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    }
}
