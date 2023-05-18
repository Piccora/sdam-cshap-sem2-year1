using System;

namespace CompanyPersonPet
{
	class Pet
	{
		public string name { get; set; }

		public Pet(string name)
		{
			this.name = name;
		}

		public Pet()
		{
			this.name = "No pet";
		}
	}
}
