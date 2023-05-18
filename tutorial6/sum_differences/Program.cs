using System;

namespace SumDifferences {
	class Program {
		public static void Main() {
			Console.WriteLine("[2, 1, 10]            should be 9: " + SumOfDifferences(new int[] {2, 1, 10}));
			Console.WriteLine("[]                    should be 0: " + SumOfDifferences(new int[0]));
			Console.WriteLine("[12]                  should be 0: " + SumOfDifferences(new int[] {12}));
			Console.WriteLine("[8, 3, 6, 1, 3, 9, 4] should be 8: " + SumOfDifferences(new int[] {8, 3, 6, 1, 3, 9, 4}));
		}

		public static int SumOfDifferences(int[] array) {
			if (array.Length <= 1) {
				return 0;
			}
			int sumDifferences = 0;
			Array.Sort(array);
			Array.Reverse(array);
	                for (int i = 0, j = array.Length; i < j - 1; i++) {
				sumDifferences += array[i] - array[i + 1];
			}
			return sumDifferences;
		}
	}
}
