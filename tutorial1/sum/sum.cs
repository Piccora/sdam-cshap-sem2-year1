using System;
using System.Collections.Generic;

namespace sum
{
	class Sum
	{
		static int positiveInts = 0;
		static int negativeInts = 0;
		static List<string> position = new List<string> {"first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth"};
		public static void Main()
		{
			for (int i = 0; i < 10; i++) {
				Console.Write($"Please enter your {position[i]} integer: ");
				int number = Int32.Parse(Console.ReadLine());
				if (number > 0)
				{
					positiveInts += number;
				}
				else if (number < 0)
				{
					negativeInts += number;
				}
			}
			Console.WriteLine($"The sum of all positive integers that you entered is: {positiveInts}");
			Console.WriteLine($"The sum of all negative integers that you entered is: {negativeInts}");
		}
	}
}
