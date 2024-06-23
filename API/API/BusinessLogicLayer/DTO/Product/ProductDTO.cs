﻿namespace API.BusinessLogicLayer.DTO.Product
{
    public class ProductDTO
    {
        Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

    }
}
