using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Models
{
    public class TransactionBorrow : BaseTransaction
    {
        public DateTime DuoDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal Penalty { get; set; }
    }
}
