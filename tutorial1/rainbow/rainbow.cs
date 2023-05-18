using System;

namespace rainbow
{
	class Rainbow
	{
		static string[] rainbow = {"Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet"};
		public static void Main()
		{
			while (true)
			{
				Console.Write("Please enter your number: ");
				int number = Convert.ToInt32(Console.ReadLine());
				if (number == -1)
				{
					break;
				}
				else if (1 <= number && number <= 7)
				{
					Console.WriteLine("The color is: " + rainbow[number - 1]);
				}
				else
				{
					Console.WriteLine("Please enter an integer between 1 to 7, or -1 to exit the program");
				}
				Console.WriteLine();
			}
		}
	}
}
