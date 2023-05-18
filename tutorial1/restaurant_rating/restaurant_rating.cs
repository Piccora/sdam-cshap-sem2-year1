using System;
using System.Collections.Generic;

namespace restaurant
{
	class RestaurantRating
	{
		static Dictionary<int, int> ratings = new Dictionary<int, int>();
		static int denominator = 0;
		static int total = 0;
		public static void Main()
		{
			for (int i = 1; i <= 5; i++)
			{
				ratings.Add(i, 0);
			}
			while (true)
			{
				Console.Write("Please enter your rating between 1 and 5, and -1 to exit: ");
				int rating = Convert.ToInt32(Console.ReadLine());
				if (rating == -1)
				{
					break;
				}
				else if (1 <= rating && rating <= 5)
				{
				ratings[rating]++;
				}
				else
				{
					Console.WriteLine("Please enter your rating as an integer between 1 and 5.");
				}
			}
			for (int i = 1; i <= 5; i++)
			{
				denominator += ratings[i];
				total += ratings[i] * i;
			}
			Console.WriteLine("---------------------------------------");
			Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|{3,5}|{4,5}|{5,5}|", 1, 2, 3, 4, 5, "Average"));
			Console.WriteLine("---------------------------------------");
			Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|{3,5}|{4,5}|{5,7}|", ratings[1], ratings[2], ratings[3], ratings[4], ratings[5], total / denominator));
			Console.WriteLine("---------------------------------------");
		}
	}
}
