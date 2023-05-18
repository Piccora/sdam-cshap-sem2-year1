using System;
using System.Collections.Generic;

namespace LibraryWithArrays {
	public class Book {
		private static int NextId = 1;
		private string author;
		public string Author
		{
			get {
				return author;
			}
			set {
				this.author = value;
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
		private string isbn;
		public string ISBN {
			get {
				return isbn;
			}
			set {
				this.isbn = value;
			}
		}
		private string title;
		public string Title {
			get {
				return title;
			}
			set {
				this.title = value;
			}
		}
		private Copy[] copies;
		public Copy[] Copies {
			get {
				return copies;
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

		public Book(string author, string isbn, string title) {
			this.NumCopies = 0;
			this.Title = title;
			this.Author = author;
			this.ISBN = isbn;
			this.Id = NextId;
			this.copies = new Copy[0];
			NextId++;
		}

		public void AddCopy(Copy c) {
			Array.Resize(ref copies, Copies.Length + 1);
			Copies[Copies.Length - 1] = c;
			NumCopies++;
		}

		public string GetAuthor() {
			return Author;
		}

		public Copy[] GetCopies() {
			return Copies;
		}

		public int GetID() {
			return Id;
		}

		public string GetISBN() {
			return isbn;
		}

		public string GetTitle() {
			return Title;
		}
	}
}
