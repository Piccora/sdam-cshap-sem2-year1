using System;

namespace Pet {
	class Cat : Pet {
		private int numberOfTeeth;
		private int lengthOfTail;

		public Cat(string name, string ownerName, int numberOfTeeth, int lengthOfTail) : base(name, ownerName) {
			this.numberOfTeeth = numberOfTeeth;
			this.lengthOfTail = lengthOfTail;
		}

		public int getNumberOfTeeth() {
			return numberOfTeeth;
		}

		public int getLengthOfTail() {
			return lengthOfTail;
		}
	}
}
