using System;

namespace ConsoleApp2

{
  class GradeCalculator
  {
   public static void Main(string[] args)
        {
            Console.WriteLine("What was your grade:");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}





       
