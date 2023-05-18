using System;
using System.Collections.Generic;

namespace CharStack {
	class CharStack {
		private List<char> stack;

		public CharStack() {
			this.stack = new List<char>();
		}

		public char pop() {
			try {
				char character = stack[stack.Count - 1];
				stack.RemoveAt(stack.Count - 1);
				return character;
			} catch (ArgumentOutOfRangeException) {
				throw new Exception("Cannot pop when stack is empty.");	
			}
		}

		public void push(char c) {
			stack.Add(c);
		}

		public bool isEmpty() {
			return stack.Count == 0;
		}
	}
}
