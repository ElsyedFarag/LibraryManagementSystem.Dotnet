using LibraryManagementSystem.Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        //public DbSet<User> Users { get; set; }
        //public DbSet<Author> Authors { get; set; }
        //public DbSet<Book> Books { get; set; }
        //public DbSet<Publisher> Publishers { get; set; }
        //public DbSet<BaseTransaction> BaseTransactions { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Feedback> Feedbacks { get; set; }
        //public DbSet<Log> Logs { get; set; }
        //public DbSet<TransactionBorrow> TransactionBorrows { get; set; }
        //public DbSet<TransactionBuy> TransactionBuys { get; set; }
    }
}
