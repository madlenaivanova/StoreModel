using System.Collections.Generic;

namespace StoreModel
{
    public class Store
    {
        public List<Product> Products { get; set; }
        public List<Seller> Sellers { get; set; }
        public Address Address { get; set; }
    }
}
