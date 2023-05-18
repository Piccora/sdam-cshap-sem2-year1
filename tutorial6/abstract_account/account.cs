using System;

namespace AbstractAccount {
	abstract class Account {
		private int sortCode;
		private int accountNumber;
		private string accountName;

		public Account(int sc, int acNum, string acName) {
			this.sortCode = sc;
			this.accountNumber = acNum;
			this.accountName = acName;
		}

		public string getAccountName() {
			return accountName;
		}

		public int getAccountNumber() {
			return accountNumber;
		}

		public int getSortCode() {
			return sortCode;
		}

		public void setSortCode(int sc) {
			this.sortCode = sc;
		}

		abstract public string toString();
	}
}
