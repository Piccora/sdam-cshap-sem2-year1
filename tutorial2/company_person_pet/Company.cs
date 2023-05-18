using System;
using System.Collections.Generic;

namespace CompanyPersonPet
{
	class Company
	{
		public string name { get; set; }
		private List<Person> companyPersonnel = new List<Person>();

		public Company(string name, List<Person> companyPersonnel)
		{
			this.name = name;
			this.companyPersonnel = companyPersonnel;
		}

		public List<Person> getCompanyPersonnel()
		{
			return companyPersonnel;
		}

		public void setCompanyPersonnel(List<Person> companyPersonnel)
		{
			this.companyPersonnel = companyPersonnel;
		}
	}
}
