using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTesting
{
    internal class Product
    {
        private int ProductID {  get; set; }

        private string ProductName { get; set; }

        private float Price { get; set; }

        private int Stock {  get; set; }
        public Product(int productID, string productName, float price, int stock )
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void increaseStock(int increment)
        {
            Stock += increment;
        }

        public void decraseStock(int decrement)
        {
            Stock -= decrement;
        }
    }
}
