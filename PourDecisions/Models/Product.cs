using System;
using System.Collections.Generic;

namespace PourDecisions.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int? Category { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }

        public virtual Category? CategoryNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
