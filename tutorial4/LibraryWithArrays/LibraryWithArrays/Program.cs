using System;

namespace LibraryWithArrays
{
    class Program
    {
	private static int VIEW_ALL_BOOKS = 1;
	private static int VIEW_ALL_MEMBERS = 2;
	private static int VIEW_ALL_LOANS = 3;
	private static int BORROW_BOOK = 4;
	private static int RENEW_LOAN = 5;
	private static int RETURN_BOOK = 6;
	private static int EXIT = 7;
	private static Library Library;

        public static void Main(string[] args)
        {
        }

	private void BorrowBook() {

	}

	private void DisplayMenu() {

	}

	private int GetInteger(string prompt) {
		return (int)this.GetType().GetField(prompt).GetValue(this);
	}

	private void RenewLoan() {

	}

	private void ReturnBook() {

	}

	private void ViewAllBooks() {
		Library.GetAllBooks();
	}

	private void ViewAllMembers() {
		Library.GetAllMembers();
	}

	private void ViewAllLoans() {
		Library.GetAllLoans();
	}
    }
}
