﻿namespace API.BusinessLogicLayer.DTO.Product
{
    public class ProductUpdateDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; } = null;
        public decimal Price { get; set; }

    }
}
