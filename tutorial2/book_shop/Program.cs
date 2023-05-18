using System;
using System.Collections.Generic;

namespace BorrowedBooks
{
	class Program
	{
		public static void Main()
		{
			BookShop bookShop = new BookShop();
			List<Book> bookList = new List<Book>();
			Random random = new Random();
			for (int i = 1; i <= 10; i++)
			{
				bookList.Add(new Book("Book " + i, "Author " + i, random.NextDouble() * 100));
				bookShop.setForSale(bookList[i - 1]);
			}
			bookShop.sellBook(bookList[1]);
			bookShop.sellBook(bookList[5]);
			bookShop.sellBook(bookList[7]);

			bookShop.calculateTotalSales();

			bookShop.sellBook(bookList[8]);
			bookShop.sellBook(bookList[3]);

			bookShop.calculateTotalSales();
		}
	}
}
