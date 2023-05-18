using System;

namespace CharStack {
	class Program {
		public static void Main(string[] args) {
			CharStack charStack = new CharStack();
			Console.Write("Please enter your sequence of brackets: ");
			string sequence = Console.ReadLine();

			foreach (char character in sequence) {
				if (character == '(') {
					charStack.push(character);
				} else if (character == ')') {
					if (charStack.isEmpty()) {
						Console.WriteLine("There is a closing bracket with no matching opening bracket.");
						Environment.Exit(1);
					}
					charStack.pop();
				} else {
					Console.WriteLine("There is an unknown character in the sequence.");
					Environment.Exit(1);
				}
			}

			if (!charStack.isEmpty()) {
				Console.WriteLine("There is an opening bracket with no matching bracket.");
			} else {
				Console.WriteLine("The sequence has well-formed brackets.");
			}
		}
	}
}
