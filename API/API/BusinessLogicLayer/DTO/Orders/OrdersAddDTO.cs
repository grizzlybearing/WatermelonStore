namespace API.BusinessLogicLayer.DTO.Orders
{
    public class OrdersAddDTO
    {
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
