using System;
using System.Collections.Generic;
using Book_Tracker;
partial class Program
{
	static void Main(string[] args)
	{
		List<Book> books = new List<Book>();
		string choice = "";
		while (choice != "5")
		{
			Console.WriteLine("========= BOOK TRACKER =========");

			Console.WriteLine("1. Add a book");

			Console.WriteLine("2. View all books");

			Console.WriteLine("3. Update a book");

			Console.WriteLine("4. Delete a book");

			Console.WriteLine("5. Exit");

			Console.Write("Enter your choice: ");

			choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					AddBook(books);
					break;

				case "2":
					ViewBooks(books);
					break;

				case "3":
					UpdateBook(books);
					break;

				case "4":
					DeleteBook(books);
					break;

				case "5":
					Console.WriteLine("Exiting...");
					break;

				default:
					Console.WriteLine("Invalid choice. Please try again.");
					break;
			}
		}

	}
	static void AddBook(List<Book> books)
	{
		Console.WriteLine("Enter book title: ");
		string title = Console.ReadLine();

		Console.WriteLine("Enter book author: ");
		string author = Console.ReadLine();

		Console.WriteLine("Enter book genre: ");
		string genre = Console.ReadLine();

		string status = "";
		do 
		{
			Console.WriteLine("Enter book status (Read/Currently Reading/Want to Read): ");
			status = Console.ReadLine();

			if (status != "Read" && status != "Currently Reading" && status != "Want to Read")
			{ 
				Console.WriteLine("Invalid status. Please enter 'Read', 'Currently Reading', or 'Want to Read'.");
			}
		} while (status != "Read" && status != "Currently Reading" && status != "Want to Read");

		Console.WriteLine("Enter book publication year: ");
		int publicationYear = int.Parse(Console.ReadLine());

		Console.WriteLine("Rate the book (1-5): ");
		int rating = int.Parse(Console.ReadLine());

		Book newBook = new Book
		{
			Title = title,
			Author = author,
			Genre = genre,
			Status = status,
			PublicationYear = publicationYear,
			Rating = rating
		};

		books.Add(newBook);
		Console.WriteLine("Book added successfully!");
	}

	static void ViewBooks(List<Book> books)

	{
	   foreach (Book book in books)
		{
			Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Status: {book.Status}, Publication Year: {book.PublicationYear}, Rating: {book.Rating}");
		}
	}

	static void UpdateBook(List<Book> books)
	{

	}

	static void DeleteBook(List<Book> books)
	{

	}
}