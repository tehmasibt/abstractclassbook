using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclas.Model
{
    internal class Product
    {       
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public Product(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
            
        }

        public void Detail()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Price: {Price}, Count: {Count}");
        }
        public int Discount(int endirim)
        {           
            int enfaizprice= 0;
            if(endirim>0)
            {
                enfaizprice = Price - (Price * endirim / 100);
                
            }
            return enfaizprice;
        }

    }
}
