namespace API.BusinessLogicLayer.DTO.Orders
{
    public class OrdersDTO
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}