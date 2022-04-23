using System;
using System.Collections.Generic;

namespace PourDecisions.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string AlcType { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
