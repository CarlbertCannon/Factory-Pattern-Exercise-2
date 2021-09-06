using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Exercise_2
{
    class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product () { Name ="PS5", Price = 499},
            new Product () { Name ="IPhone", Price = 1299},
            new Product () { Name ="Total Gym", Price = 899},
            new Product () { Name ="Mountain Bike", Price = 1599},

        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a List Data Access.");

            return Products;
        }


        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List Data Access.");
        }
    }
}
