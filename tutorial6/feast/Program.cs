using System;

namespace Feast {
	class Program {
		public static void Main() {
			Console.WriteLine(Feast("chicken", "curry and chips"));
			Console.WriteLine(Feast("chamois", "curry and chips"));
		}

		public static bool Feast(string animalName, string dish) {
			return animalName[0] == dish[0] && animalName[animalName.Length - 1] == dish[dish.Length - 1];
		}
	}
}
