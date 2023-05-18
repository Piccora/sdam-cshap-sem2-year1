using System;

namespace LibraryWithArrays {
	public class Copy {
		public static string AVAILABLE_STATE = "Available";
		public static string ON_LOAN_STATE = "On loan";
		private static int NextId = 1;
		private int id;
		public int Id {
			get {
				return id;
			}
			set {
				this.id = value;
			}
		}
		private Book book;
		public Book Book {
			get {
				return book;
			}
			set {
				this.book = value;
			}
		}
		private string state;
		public string State {
			get {
				return state;
			}
			set {
				this.state = value;
			}
		}

		public Copy(Book book) {
			this.Book = book;
			this.Book.AddCopy(this);
			this.Id = NextId;
			NextId++;
			this.state = AVAILABLE_STATE;
		}

		public Book GetBook() {
			return Book;
		}

		public int GetID() {
			return Id;
		}

		public string GetState() {
			return State;
		}

		public void SetState(string s) {
			this.State = s;
		}
	}
}
