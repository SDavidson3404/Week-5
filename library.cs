using System;
using System.Collections.Generic;
// Define a Book class with properties like ISBN, title, author, and status (e.g., available, checked out).

public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsCheckedOut { get; set; }
    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
        IsCheckedOut = false;
    }
}
// Define a Library class to manage a collection of books.
public class Library
{
    private List<Book> books = new List<Book>();
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");
    }
    public void RemoveBook(string isbn)
    {
        var book = books.Find(b => b.ISBN == isbn);
        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine($"Book '{book.Title}' removed from the library.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
    public void CheckOutBook(string isbn)
    {
        var book = books.Find(b => b.ISBN == isbn);
        if (book != null && !book.IsCheckedOut)
        {
            book.IsCheckedOut = true;
            Console.WriteLine($"Book '{book.Title}' checked out.");
        }
        else if (book == null)
        {
            Console.WriteLine("Book not found.");
        }
        else
        {
            Console.WriteLine("Book is already checked out.");
        }
    }
    public void ReturnBook(string isbn)
    {
        var book = books.Find(b => b.ISBN == isbn);
        if (book != null && book.IsCheckedOut)
        {
            book.IsCheckedOut = false;
            Console.WriteLine($"Book '{book.Title}' returned.");
        }
        else if (book == null)
        {
            Console.WriteLine("Book not found.");
        }
        else
        {
            Console.WriteLine("Book was not checked out.");
        }
    }
    public void ListBooks()
    {
        foreach (var book in books)
        {
            string status = book.IsCheckedOut ? "Checked Out" : "Available";
            Console.WriteLine($"{book.Title} by {book.Author} (ISBN: {book.ISBN}) - {status}");
        }
    }
}

// Implement methods for adding, removing, checking out, and returning books.

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Check Out Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. List Books");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();
                    library.AddBook(new Book(isbn, title, author));
                    break;
                case "2":
                    Console.Write("Enter ISBN of the book to remove: ");
                    isbn = Console.ReadLine();
                    library.RemoveBook(isbn);
                    break;
                case "3":
                    Console.Write("Enter ISBN of the book to check out: ");
                    isbn = Console.ReadLine();
                    library.CheckOutBook(isbn);
                    break;
                case "4":
                    Console.Write("Enter ISBN of the book to return: ");
                    isbn = Console.ReadLine();
                    library.ReturnBook(isbn);
                    break;
                case "5":
                    library.ListBooks();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}