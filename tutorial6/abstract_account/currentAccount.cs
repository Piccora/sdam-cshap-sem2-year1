using System;

namespace AbstractAccount {
	class CurrentAccount : Account {
		private double overdraftLimit;

		public CurrentAccount(int sc, int acNum, string acName, double overdraftLimit) : base(sc, acNum, acName) {
			this.overdraftLimit = overdraftLimit;
		}

		public double getOverdraftLimit() {
			return overdraftLimit;
		}

		public void setOverdraftLimit(double limit) {
			this.overdraftLimit = limit;
		}

		public override string toString() {
			return String.Format("Account name: {0}\nAccount number: {1}\nSort code: {2}\nOverdraft limit: {3}\n", base.getAccountName(), Convert.ToString(base.getAccountNumber()), Convert.ToString(base.getSortCode()), Convert.ToString(this.getOverdraftLimit()));
		}
	}
}
