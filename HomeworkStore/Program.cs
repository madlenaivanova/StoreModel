using StoreModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4Store
{
    class Program
    {
        public static void Main(string[] args)
        {
            Store store = new Store
            {
                Address = new Address
                {
                    City = "Sofia",
                    StreetName = "Oborishte",
                    StreetNumber = "1",
                    PostalCode = "1000"
                },
                Products = new List<Product>
                {
                    new Product
                    {
                        Name = "Product1",
                        Price= 1.00M,
                        Weight= 1,
                        CurrencyCode= "BGN",
                        ExpirationDate = new DateTime (2019,12, 20)
                    },
                    new Product
                    {
                        Name = "Product2",
                        Price= 2.00M,
                        Weight= 2,
                        CurrencyCode= "BGN",
                        ExpirationDate = new DateTime (2019,12, 22)
                    }
                },
                Sellers = new List<Seller>
                {
                     new Seller
                     {
                        SellerName= "Ivan",
                        SellerAge= 20,
                        ExperienceAge= 1
                     },
                     new Seller
                     {
                     SellerName="Gosho",
                     SellerAge= 30,
                     ExperienceAge = 5
                     }
                }
            };


            Console.WriteLine(store.Sellers.First().SellerName);

            Console.WriteLine(store.Products[1].Name);

            Console.ReadLine();

        }
    }
}
