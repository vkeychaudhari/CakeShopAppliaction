using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeShop.Domain.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public Account Account { get; set; }

        public Item Item { get; set; }
    }
}
