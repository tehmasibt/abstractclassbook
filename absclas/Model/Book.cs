using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclas.Model
{
    internal class Book:Product
    {
        public string Genre;

        public Book(string genre, int id, string name, int price):base(id,name,price) 
        {
            Genre = genre;
           
        }
    }
}
