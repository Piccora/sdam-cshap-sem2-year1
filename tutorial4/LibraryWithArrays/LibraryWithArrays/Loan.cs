using System;

namespace LibraryWithArrays {
	public class Loan {
		private static int NextId = 1;
		private Member borrower;
		public Member Borrower {
			get {
				return borrower;
			}
			set {
				this.borrower = value;
			}
		}
		private Copy copy;
		public Copy Copy {
			get {
				return copy;
			}
			set {
				this.copy = value;
			}
		}
		private DateTime dueDate;
		public DateTime DueDate {
			get {
				return dueDate;
			}
			set {
				this.dueDate = value;
			}
		}
		private int id;
		public int Id {
			get {
				return id;
			}
			set {
				this.id = value;
			}
		}
		private DateTime loanDate;
		public DateTime LoanDate {
			get {
				return loanDate;
			}
			set {
				this.loanDate = value;
			}
		}
		private int numberOfRenewals;
		public int NumberOfRenewals {
			get {
				return numberOfRenewals;
			}
			set {
				this.numberOfRenewals = value;
			}
		}
		private DateTime returnDate;
		public DateTime ReturnDate {
			get {
				return returnDate;
			}
			set {
				this.returnDate = value;
			}
		}

		public Loan(Member m, Copy c) {
			this.Copy = c;
			this.Borrower = m;
			this.Id = NextId;
			NextId++;
			this.LoanDate = DateTime.Now;
			this.DueDate = LoanDate.AddDays(14);
			this.ReturnDate = new DateTime(0);
			this.NumberOfRenewals = 0;
			this.Copy.SetState(Copy.ON_LOAN_STATE);
		}

		public Copy GetCopy() {
			return Copy;
		}

		public int GetID() {
			return Id;
		}

		public Member GetBorrower() {
			return Borrower;
		}

		public DateTime GetLoanDate() {
			return LoanDate;
		}

		public DateTime GetDueDate() {
			return DueDate;
		}

		public int GetNumberOfRenewals() {
			return NumberOfRenewals;
		}

		public DateTime GetReturnDate() {
			return ReturnDate;
		}

		public Boolean RenewLoan() {
			if (NumberOfRenewals >= 3) {
				return false;
			}
			else {
				NumberOfRenewals++;
				this.DueDate = DueDate.AddDays(14);
				return true;
			}
		}

		public Boolean ReturnBook() {
			if (ReturnDate.ToBinary() != 0) {
				return false;
			}
			else {
				this.Copy.SetState(Copy.AVAILABLE_STATE);
				this.ReturnDate = DateTime.Now;
				return true;
			}
		}
	}
}
