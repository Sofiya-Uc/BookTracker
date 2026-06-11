using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
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
		
		int rating = 0;
		do
		{   
			Console.WriteLine("Rate the book (1-5): ");
			rating = int.Parse(Console.ReadLine());

			if(rating < 1 || rating > 5)
			{
				Console.WriteLine("Invalid rating. Please enter a number between 1 and 5.");
			}
		} while (rating < 1 || rating > 5);

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
        if (books.Count == 0)
		{
			Console.WriteLine("No books yet!! Add a book first.");
			return;
		}
		for (int i = 0; i < books.Count; i++)
		{
			Console.WriteLine($" {i + 1}. Title: {books[i].Title}, Author: {books[i].Author}, Genre: {books[i].Genre}, Status: {books[i].Status}, Publication Year: {books[i].PublicationYear}, Rating: {books[i].Rating}");
		}
	}

	static void UpdateBook(List<Book> books)
	{
		ViewBooks(books);

		Console.WriteLine("Enter the number of the book you want to update: ");
		int index = int.Parse(Console.ReadLine()) - 1;

		if (index < 0 || index >= books.Count)
		{
			Console.WriteLine("Invalid book number. Please try again.");
			return;
		}

		for (int i = 0; i < books.Count; i++)
		{
			if (i == index)
			{
				Console.WriteLine("Enter new book title: ");
				books[index].Title = Console.ReadLine();

				Console.WriteLine("Enter new book author: ");
				books[index].Author = Console.ReadLine();

				Console.WriteLine("Enter new book genre: ");
				books[index].Genre = Console.ReadLine();

				string status = "";
				do{
				     Console.WriteLine("Enter new book status (Read/Currently Reading/Want to Read): ");
				     status = Console.ReadLine();

				   if (status != "Read" && status != "Currently Reading" && status != "Want to Read")
				     {
					    Console.WriteLine("Invalid status. Please enter 'Read', 'Currently Reading', or 'Want to Read'.");
				     }
			    } while (status != "Read" && status != "Currently Reading" && status != "Want to Read") ;


			Console.WriteLine("Enter new book publication year: ");
				books[index].PublicationYear = int.Parse(Console.ReadLine());
			}
		}
	}

		static void DeleteBook(List<Book> books)
		{
		ViewBooks(books);

	Console.WriteLine("Enter the number of the book you want to delete: ");
		int index = int.Parse(Console.ReadLine()) - 1;

		if (index < 0 || index >= books.Count)
		{
			Console.WriteLine("Invalid book number. Please try again.");
			return;
		}


		books.RemoveAt(index);

		Console.WriteLine("Book deleted successfully!");
		}
	}