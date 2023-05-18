using System;

namespace AbstractAccount {
	class Program {
		public static void Main() {
			CurrentAccount account1 = new CurrentAccount(174895, 113, "Harry", 100.15);
			SavingsAccount account2 = new SavingsAccount(572048, 420, "John", 7.5);

			Console.WriteLine(account1.toString());
			Console.WriteLine(account2.toString());
		}
	}
}
