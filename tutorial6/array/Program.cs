using System;

namespace PopulateArray {
	class Program {
		public static void Main() {
			Console.WriteLine(Enumerable.SequenceEqual(PopulateArray(2), new int[] {1, 2}));
			Console.WriteLine(Enumerable.SequenceEqual(PopulateArray(6), new int[] {1, 2, 3, 4, 5, 6}));
		}

		public static int[] PopulateArray(int n) {
			try {
				if (n <= 0) {
					return null;
				}
				int[] array = new int[n];
				for (int i = 1; i <= n; i++) {
					array[i - 1] = i;
				}
				return array;
			} catch(Exception) {
				throw new Exception("Please provide a integer number.");
			}
		}
	}
}
