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
    internal class TransactionBorrowConfiguration : IEntityTypeConfiguration<TransactionBorrow>
    {
        public void Configure(EntityTypeBuilder<TransactionBorrow> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Books).WithMany(b => b.TransactionBorrows);
            builder.HasOne(x => x.User).WithMany(x => x.TransactionBorrows).HasForeignKey(x => x.UserId);
        }
    }
}
