using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Homework
{
 
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
