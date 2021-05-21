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
			var country = Console.ReadLine();
			switch (country)
			{
				case "England":
					Console.WriteLine("English");
					break;
				case "USA":
					Console.WriteLine("English");
					break;
				case "Spain":
					Console.WriteLine("Spanish");
					break;
				case "Argentina ":
					Console.WriteLine("Spanish");
					break;
				case "Mexico":
					Console.WriteLine("Spanish");
					break;

				default:
					Console.WriteLine("unknown");
					break;

			}
		}
    }
}
