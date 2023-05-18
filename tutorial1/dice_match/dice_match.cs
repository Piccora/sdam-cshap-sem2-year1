using System;

namespace dice
{
	class diceMatch
	{
		static int count = 0;
		public static void Main()
		{
			Random rnd1 = new Random();
			do
			{
				int first_roll = rnd1.Next(1, 7);
				int second_roll = rnd1.Next(1, 7);
				Console.WriteLine("First roll: " + first_roll);
				Console.WriteLine("Second roll: " + second_roll);
				count++;
				if (first_roll == second_roll) 
				{
					Console.WriteLine("You found the matching pair! It took " + count + " turns!");
					break;
				}
				Console.WriteLine();
			}
			while (true);
		}
	}
}
