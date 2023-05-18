using System;

namespace Pet {
	class Pet {
		private string name;
		private string ownerName;

		public Pet(string name, string ownerName) {
			this.name = name;
			this.ownerName = ownerName;
		}

		public string getName() {
			return name;
		}

		public string getOwnerName() {
			return ownerName;
		}
	}
}
