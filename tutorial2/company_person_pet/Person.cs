using System;

namespace CompanyPersonPet
{
	class Person
	{
		public string name{ get; set; }
		public Pet personPet{ get; set; }

		public Person(string name, Pet personPet)
		{
			this.name = name;
			this.personPet = personPet;
		}
	}
}
