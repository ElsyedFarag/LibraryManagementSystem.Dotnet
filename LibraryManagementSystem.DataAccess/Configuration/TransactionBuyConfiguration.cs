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
    internal class TransactionBuyConfiguration : IEntityTypeConfiguration<BaseTransaction>
    {
        public void Configure(EntityTypeBuilder<BaseTransaction> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Books).WithMany(b => b.TransactionBuys);
            builder.HasOne(x => x.User).WithMany(x => x.TransactionBuys).HasForeignKey(x => x.UserId);
        }
    }
}
