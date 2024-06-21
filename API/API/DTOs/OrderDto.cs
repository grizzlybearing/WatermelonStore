using System;

public record OrdersDto
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public int UserId { get; set; }
    public List<OrderItemDto>? OrderItems { get; set; }
}
