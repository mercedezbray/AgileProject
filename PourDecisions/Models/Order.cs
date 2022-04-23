using System;
using System.Collections.Generic;

namespace PourDecisions.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; }

        // public static implicit operator Order(Order v)
        // {
        //     throw new NotImplementedException();
        // }
    }
}
