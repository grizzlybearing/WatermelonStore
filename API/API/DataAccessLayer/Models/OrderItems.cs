﻿namespace API.DataAccessLayer.Models
{
    public class OrderItems
    {
        public int Id { get; set; }
        public int OrderId { get; set; }  
        public Orders Order { get; set; }  
        public int ProductId { get; set; }  
        public Product Product { get; set; }  
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}