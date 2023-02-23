using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeShop.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }

        public User AccountHolder { get; set; } 

        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
