using System;

namespace grid
{
	class Grid 
	{
		public static void Main()
		{
			Console.Write("Please enter the number of columns for the grid: ");
			int columns = Int32.Parse(Console.ReadLine());
			Console.Write("Please enter the number of rows for the grid: ");
			int rows = Int32.Parse(Console.ReadLine());
			
			for (int i = 0; i < rows; i++) {
				for (int j = 0; j < columns; j++) {
					Console.Write("*");
				}
				Console.Write("\n");
			}
		}
	}
}
