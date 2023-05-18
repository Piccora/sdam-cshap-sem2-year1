using System;

namespace CharStack {
	class Program {
		public static void Main(string[] args) {
			CharStack charStack = new CharStack();
			Console.Write("Please enter your sequence of brackets: ");
			string sequence = Console.ReadLine();

			Dictionary<char, char> charDict = new Dictionary<char, char>() {{'(', ')'}, {'[', ']'}, {'{', '}'}};
			List<char> charListOpening = new List<char>() {'(', '[', '{'};
			List<char> charListEnding = new List<char>() {')', ']', '}'};
			foreach (char character in sequence) {
				if (charListOpening.Contains(character)) {
					charStack.push(character);
				} else if (charListEnding.Contains(character)) {
					if (charStack.isEmpty() || charDict[charStack.pop()] != character) {
						Console.WriteLine("There is a closing bracket with no matching opening bracket.");
						Environment.Exit(1);
					}
				} else {
					Console.WriteLine("There is an unknown character in the sequence.");
					Environment.Exit(1);
				}
			}

			if (!charStack.isEmpty()) {
				Console.WriteLine("There is an opening bracket with no matching closing bracket.");
			} else {
				Console.WriteLine("The sequence has well-formed brackets.");
			}
		}
	}
}
