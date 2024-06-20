namespace API.DataAccessLayer.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; } 
        public User User { get; set; }  
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
