using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics
{
    internal class IsEligible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Math Marks : ");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Physics Marks : ");
            int physics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Chemistry Marks : ");
            int Chemistry = int.Parse(Console.ReadLine());

            int total = physics + Chemistry + math;

            if(total>=180 && math >= 65 && physics >= 55 && Chemistry >= 50)
            {
                Console.WriteLine("Congratulations..Your are Eligible for Pg-Dac");
            }
            else
            {
                Console.WriteLine("Sorry...your are not Eligible ");
            }
        }
    }
}
