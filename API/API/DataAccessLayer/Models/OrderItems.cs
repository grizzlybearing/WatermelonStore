namespace API.DataAccessLayer.Models
{
    public class OrderItems : BaseModel
    {
        public Guid OrderId { get; set; } 
        public Orders Order { get; set; }
        public Guid ProductId { get; set; } 
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
