using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.DataAccess.Configuration
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Publisher).WithMany(x => x.Books).HasForeignKey(x => x.PublisherId);
            builder.HasOne(x => x.Category).WithMany(x => x.Books).HasForeignKey(x => x.CategoryId);
            builder.HasMany(x => x.Feedbacks).WithOne(x => x.Book).HasForeignKey(x => x.BookId);
            builder.HasMany(x => x.TransactionBuys).WithMany(b => b.Books);
            builder.HasMany(x => x.TransactionBorrows).WithMany(b => b.Books);
        }
    }
}
