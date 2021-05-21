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
			if (grade > 2.99)
			{
				Console.WriteLine("Passed!");
			}
			else
			{
				Console.WriteLine("Failed!");
			}
		}
    }
}
