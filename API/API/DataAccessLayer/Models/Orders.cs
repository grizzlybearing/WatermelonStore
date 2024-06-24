namespace API.DataAccessLayer.Models
{
    public class Orders : BaseModel
    {
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; } 
        public User User { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
