using System;
using System.Collections.Generic;

namespace LibraryWithArrays {
	 public class Library {
		private Book[] books;
		public Book[] Books {
			get {
				return books;
			}
		}
		private Copy[] copies;
		public Copy[] Copies {
			get {
				return copies;
			}
		}
		private Loan[] loans;
		public Loan[] Loans {
			get {
				return loans;
			}
		}
		private Member[] members;
		public Member[] Members {
			get {
				return members;
			}
		}
		private int numBooks;
		public int NumBooks {
			get {
				return numBooks;
			}
			set {
				this.numBooks = value;
			}
		}
		private int numCopies;
		public int NumCopies {
			get {
				return numCopies;
			}
			set {
				this.numCopies = value;
			}
		}
		private int numLoans;
		public int NumLoans {
			get {
				return numLoans;
			}
			set {
				this.numLoans = value;
			}
		}
		private int numMembers;
		public int NumMembers {
			get {
				return numMembers;
			}
			set {
				this.numMembers = value;
			}
		}

		public Loan BorrowBook(int copyID, int memberID) {
			return new Loan(FindMember(memberID), FindCopy(copyID));
		}

		private Copy FindCopy(int copyID) {
			Copy temp = null;
			foreach (Copy copy in Copies) {
				if (copy.GetID() == copyID) {
					temp = copy;
					break;
				}
			}
			return temp;
		}

		private Loan FindLoan(int copyID, int memberID) {
			Loan temp = null;
			foreach (Loan loan in Loans) {
				if (loan.GetCopy().GetID() == copyID && loan.GetBorrower().GetID() == memberID) {
					temp = loan;
					break;
				}
			}
			return temp;
		}

		private Member FindMember(int memberID) {
			Member temp = null;
			foreach (Member member in Members) {
				if (member.GetID() == memberID) {
					temp = member;
					break;
				}
			}
			return temp;
		}

		public Book[] GetAllBooks() {
			return Books;
		}

		public Loan[] GetAllLoans() {
			return Loans;
		}

		public Member[] GetAllMembers() {
			return Members;
		}

		public Loan RenewLoan(int copyID, int memberID) {
			Loan loan = FindLoan(copyID, memberID);
			loan.RenewLoan();
			return loan;
		}

		public Loan ReturnBook(int copyID, int memberID) {
			Loan loan = FindLoan(copyID, memberID);
			loan.ReturnBook();
			return loan;
		}
	}
}
