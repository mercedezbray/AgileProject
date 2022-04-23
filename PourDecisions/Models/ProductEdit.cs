namespace PourDecisions.Models
{
    public class ProductEdit
    {
        public int? Category { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }

        public virtual Category? CategoryNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}