using System;
using System.Collections.Generic;
using System.Text;

namespace day_2
{
    class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Eligible for voting ");
            }
            else if (age >= 60)
            {
                Console.WriteLine("he is senior citizen and eligible for voting ");
            }
            else
            {
                Console.WriteLine("not eligible for voting");
            }
        }
    }
}
