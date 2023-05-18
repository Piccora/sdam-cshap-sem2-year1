using System;
using System.Collections.Generic;

namespace CompanyPersonPet
{
	class companyPersonPet
	{
		public static void Main()
		{
			List<Person> personnels = new List<Person>() {new Person("Dave", new Pet("Daniel")), new Person("Mason", new Pet("Lucy")), new Person("Jack", new Pet())};
			Company company1 = new Company("Prospect Excavation", personnels);
			Console.WriteLine("The company name is: " + company1.name);
			Console.WriteLine();
			Console.WriteLine("The company employees, along with their pet are:");
			for (int i = 0; i < personnels.Count; i++)
			{
				Person personnel = company1.getCompanyPersonnel()[i];
				Console.WriteLine("Employee: " + personnel.name);
				Console.WriteLine("Pet: " + personnel.personPet.name);
				Console.WriteLine();
			}
		}
	}
}
