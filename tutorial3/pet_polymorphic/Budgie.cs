using System;

namespace Pet {
	class Budgie : Pet {
		private string colourOfFeathers;

		public Budgie(string name, string ownerName, string colourOfFeathers) : base(name, ownerName) {
			this.colourOfFeathers = colourOfFeathers;
		}

		public string getColourOfFeathers() {
			return colourOfFeathers;
		}
	}
}
