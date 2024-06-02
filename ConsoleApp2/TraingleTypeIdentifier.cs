using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TraingleTypeIdentifier
    {
        public static void Main(string[] args) {
            Console.WriteLine("Enter the first side of the triangle:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second side of the triangle:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third side of the triangle:");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x = y = z)
            {
                Console.Write("This triangle is an Equilateral triangle.");
            }
            else if(x=y || x=z || y=z) {
                Console.Write("This traingle is an Isoseles triangle.");
            }
            else
            {
                Console.Write("This triangle is a Scalene Triangle.");
            }



            }
    }
}
