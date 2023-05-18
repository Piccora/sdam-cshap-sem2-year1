using System;

namespace Square {
	class Program {
		public static void Main() {
			Console.WriteLine(isSquare(-1));
			Console.WriteLine(isSquare(0));
			Console.WriteLine(isSquare(3));
			Console.WriteLine(isSquare(4));
			Console.WriteLine(isSquare(25));
			Console.WriteLine(isSquare(26));
		}

		public static bool isSquare(int n) {
			if (n < 0) {
				return false;
			}
			double squareRoot = Math.Sqrt(n);
			return Math.Floor(squareRoot) == Math.Ceiling(squareRoot);
		}
	}
}
