using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUII
{
    internal class Program 
    {
         void Main(string[] args)
        {
            CarmManeger carmManeger = new CarmManeger();
            foreach (var cars in carManeger.GetAll())
            {
                Console.WriteLine(cars.CarId);
                
            }
        }
    }
}
