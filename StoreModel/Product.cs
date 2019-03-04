using System;

namespace StoreModel
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CurrencyCode { get; set; }
        public double Weight { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
