﻿namespace ApiStore.Models.Product
{
    public class ProductItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public List<string>? Images { get; set; }
    }
}
