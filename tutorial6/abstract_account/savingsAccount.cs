using System;

namespace AbstractAccount {
	class SavingsAccount : Account {
		private double interestRate;

		public SavingsAccount(int sc, int acNum, string acName, double interestRate) : base(sc, acNum, acName) {
			this.interestRate = interestRate;
		}

		public double getInterestRate() {
			return interestRate;
		}

		public void setInterestRate(double rate) {
			this.interestRate = rate;
		}

		public override string toString() {
			return String.Format("Account name: {0}\nAccount number: {1}\nSort code: {2}\nInterest rate: {3}", base.getAccountName(), Convert.ToString(base.getAccountNumber()), Convert.ToString(base.getSortCode()), Convert.ToString(this.getInterestRate()));
		}
	}
}
