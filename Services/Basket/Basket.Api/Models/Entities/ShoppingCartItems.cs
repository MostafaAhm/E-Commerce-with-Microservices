﻿namespace Basket.Api.Models.Entities
{
    public class ShoppingCartItems
    {
        public int Quantity { get; set; }
        public string? Color { get; set; }
        public decimal Price { get; set; }
        public string? ProductID { get; set; }
        public string? ProductName { get; set; }
    }
}