using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using esercizio_factory.Model;

namespace esercizio_factory
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ICar car = Renter.Rent(180);

            Console.WriteLine("mi hanno dato una " + car.Model());
            Console.ReadKey();
        }
    }
}
