using System;
using System.Collections.Generic;

namespace Pet {
	class Program {
		public static void printPetDetails(List<Pet> petArray) {
			Console.WriteLine(String.Format("{0,5}   {1,5}   {2,10}   {3,5}   {4,11}   {5,14}", "All pets" , "", "", "", "", ""));
			Console.WriteLine(String.Format("{0,5}   {1,5}   {2,10}   {3,5}   {4,11}   {5,14}", "========" , "", "", "", "", ""));
			Console.WriteLine(String.Format("{0,5}   {1,5}   {2,5}   {3,5}   {4,5}   {5,5}", "" , "Pet name", "Owner name", "Teeth", "Tail length", "Feather colour"));
			Console.WriteLine(String.Format("{0,5}   {1,5}   {2,5}   {3,5}   {4,5}   {5,5}", "" , "========", "==========", "=====", "===========", "=============="));
			for (int i = 0; i < petArray.Count; i++) {
				if (petArray[i] is Cat) {
					Cat cat = (Cat)petArray[i];
					Console.WriteLine(String.Format("{0,5}   {1,8}   {2,10}   {3,5}   {4,11}   {5,14}", "", cat.getName(), cat.getOwnerName(), cat.getNumberOfTeeth(), cat.getLengthOfTail().ToString("D2"), "---"));
				}
				else if (petArray[i] is Budgie) {
					Budgie budgie = (Budgie)petArray[i];
					Console.WriteLine(String.Format("{0,5}   {1,8}   {2,10}   {3,5}   {4,11}   {5,14}", "", budgie.getName(), budgie.getOwnerName(), "---", "---", budgie.getColourOfFeathers()));
				}
				else {
					Console.WriteLine("Error");
				}
			}
		}
		public static void Main(String[] args) {
			List<Pet> petList = new List<Pet>();
			List<string> colourList = new List<string> {"Blue", "Yellow", "Green", "White"};
			petList.Add(new Cat("Cat 1", "Owner 10", 28, 2));
			petList.Add(new Cat("Cat 2", "Owner 11", 24, 4));
			for (int i = 0; i < 4; i++) {
				petList.Add(new Cat("Cat " + Convert.ToString(i + 3), "Owner " + Convert.ToString(i + 12), 26 - i, 6 + 2 * i));
			}

			for (int i = 0; i < 4; i++) {
				petList.Add(new Budgie("Budgie " + Convert.ToString(i + 1), "Owner " + Convert.ToString(i + 21), colourList[i]));
			}

			printPetDetails(petList);
		}
	}
}
