using System;

namespace Pet {
	class Program {
		public static void Main(String[] args) {
			Cat cat1 = new Cat("Cat 1", "Owner 1", 28, 10);
			Cat cat2 = new Cat("Cat 2", "Owner 1", 24, 12);
			Cat cat3 = new Cat("Cat 3", "Owner 2", 26, 15);
			Budgie budgie1 = new Budgie("Budgie 1", "Owner 2", "Blue");
			Budgie budgie2 = new Budgie("Budgie 2", "Owner 3", "Yellow");

			Console.WriteLine(String.Format("{0,5}   {1,5}   {2,10}   {3,5}   {4,11}   {5,14}", "All pets" , "", "", "", "", ""));
			Console.WriteLine(String.Format("{0,5}   {1,5}   {2,10}   {3,5}   {4,11}   {5,14}", "========" , "", "", "", "", ""));
			Console.WriteLine(String.Format("{0,5}   {1,5}   {2,5}   {3,5}   {4,5}   {5,5}", "" , "Pet name", "Owner name", "Teeth", "Tail length", "Feather colour"));
			Console.WriteLine(String.Format("{0,5}   {1,5}   {2,5}   {3,5}   {4,5}   {5,5}", "" , "========", "==========", "=====", "===========", "=============="));
			Console.WriteLine(String.Format("{0,5}   {1,8}   {2,10}   {3,5}   {4,11}   {5,14}", "" , cat1.getName(), cat1.getOwnerName(), cat1.getNumberOfTeeth(), cat1.getLengthOfTail(), "---"));
			Console.WriteLine(String.Format("{0,5}   {1,8}   {2,10}   {3,5}   {4,11}   {5,14}", "" , cat2.getName(), cat2.getOwnerName(), cat2.getNumberOfTeeth(), cat2.getLengthOfTail(), "---"));
			Console.WriteLine(String.Format("{0,5}   {1,8}   {2,10}   {3,5}   {4,11}   {5,14}", "" , cat3.getName(), cat3.getOwnerName(), cat3.getNumberOfTeeth(), cat3.getLengthOfTail(), "---"));
			Console.WriteLine(String.Format("{0,5}   {1,5}   {2,10}   {3,5}   {4,11}   {5,14}", "" , budgie1.getName(), budgie1.getOwnerName(), "---", "---", budgie1.getColourOfFeathers()));
			Console.WriteLine(String.Format("{0,5}   {1,5}   {2,10}   {3,5}   {4,11}   {5,14}", "" , budgie2.getName(), budgie2.getOwnerName(), "---", "---", budgie2.getColourOfFeathers()));
		}
	}
}
