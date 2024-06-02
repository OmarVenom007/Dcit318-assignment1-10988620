using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TicketPriceCalculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >=65 || age <= 12 ) {
                Console.Write("The price of your ticket is GHC 7");
            }
            else
            {
                Console.Write("The price of your ticket is GHC 10");
            }
          
        }
    }
}
