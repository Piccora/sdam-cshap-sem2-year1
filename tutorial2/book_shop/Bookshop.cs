using System;
using System.Collections.Generic;

namespace BorrowedBooks
{
	class BookShop
	{
		public List<Book> forSale = new List<Book>();
		private List<Book> soldBooks = new List<Book>();
		private double totalSales = 0;

		public List<Book> getForSale()
		{
			return forSale;
		}

		public void setForSale(Book book)
		{
			this.forSale.Add(book);
		}

		public List<Book> getSoldBooks()
		{
			return soldBooks;
		}

		public void setSoldBooks(Book book)
		{
			this.soldBooks.Add(book);
		}

		public void sellBook(Book book)
		{
			if (forSale.Contains(book))
			{
				int bookIndex = forSale.IndexOf(book);
				this.setSoldBooks(forSale[bookIndex]);
				forSale.RemoveAt(bookIndex);
			}
			else
			{
				Console.WriteLine("Book not found.");
			}
		}

		public void calculateTotalSales()
		{
			for (int i = 0; i < soldBooks.Count; i++)
			{
				this.totalSales += soldBooks[i].price;
			}
			Console.WriteLine("The total sales was: " + Math.Truncate(totalSales));
			this.totalSales = 0;
		}
	}
}
