using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem
{
    class Program
    {
        static void Wait(int delay)
        {
            Thread.Sleep(delay);
        }
        static void Main(string[] args)
        {
            string greeting = "Dahlia Technologies";
            string tagline = "Architects of Innovation";

            Console.WriteLine(greeting);
            Wait(5000);
            Console.WriteLine(tagline);
        }
    }
}
