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
			var day = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			double ticket = 0;

			if (day == "Weekday")
			{
				if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
				{
					ticket = 12;
					Console.WriteLine($"{ticket}$");
				}
				else if (age > 18 && age <= 64)
				{
					ticket = 18;
					Console.WriteLine($"{ticket}$");
				}
				else if (age < 0 || age > 122)
				{
					Console.WriteLine("Error!");
				}
			}

			else if (day == "Weekend")
			{
				if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
				{
					ticket = 15;
					Console.WriteLine($"{ticket}$");
				}
				else if (age > 18 && age <= 64)
				{
					ticket = 20;
					Console.WriteLine($"{ticket}$");
				}
				else if (age < 0 || age > 122)
				{
					Console.WriteLine("Error!");
				}
			}

			else if (day == "Holiday")
			{
				if (age >= 0 && age <= 18)
				{
					ticket = 5;
					Console.WriteLine($"{ticket}$");
				}
				else if (age > 18 && age <= 64)
				{
					ticket = 12;
					Console.WriteLine($"{ticket}$");
				}
				else if (age > 64 && age <= 122)
				{
					ticket = 10;
					Console.WriteLine($"{ticket}$");
				}
				else if (age < 0 || age > 122)
				{
					Console.WriteLine("Error!");
				}
			}


			else
			{
				Console.WriteLine("Error!");
			}
		}
	}
}
