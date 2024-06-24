﻿namespace API.BusinessLogicLayer.DTO.Product
{
    public class ProductAddDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }

    }
}
