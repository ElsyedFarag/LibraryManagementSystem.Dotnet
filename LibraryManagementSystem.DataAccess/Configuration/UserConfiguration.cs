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
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.TransactionBorrows).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.TransactionBuys).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Feedbacks).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Logs).WithOne(x => x.User).HasForeignKey(x => x.UserId);
        }
    }
}
