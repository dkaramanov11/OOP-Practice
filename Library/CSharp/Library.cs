using System;
using System.Collections.Generic;

namespace OOP_Practice.Library.CSharp
{
    internal class Book
    {
        public int Id { get; }
        public string Title { get; }
        public string Author { get; }
        public bool IsBorrowed { get; private set; }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
            IsBorrowed = false;
        }

        public void Borrow()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"Book '{Title}' is already borrowed.");
                return;
            }

            IsBorrowed = true;
            Console.WriteLine($"Book '{Title}' borrowed successfully.");
        }

        public void Return()
        {
            if (!IsBorrowed)
            {
                Console.WriteLine($"Book '{Title}' is not borrowed.");
                return;
            }

            IsBorrowed = false;
            Console.WriteLine($"Book '{Title}' returned successfully.");
        }

        public void PrintInfo()
        {
            Console.WriteLine(
                $"ID: {Id}, Title: {Title}, Author: {Author}, " +
                $"Borrowed: {IsBorrowed}");
        }
    }

    internal class Library
    {
        public string Name { get; }

        private readonly List<Book> books = new List<Book>();

        public Library(string name)
        {
            Name = name;
        }

        public void AddBook(Book? book)
        {
            if (book == null)
            {
                Console.WriteLine("Book cannot be null.");
                return;
            }

            if (FindBook(book.Id) != null)
            {
                Console.WriteLine(
                    $"A book with ID {book.Id} already exists.");
                return;
            }

            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added successfully.");
        }

        private Book? FindBook(int id)
        {
            foreach (Book book in books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }

            return null;
        }

        public void BorrowBook(int id)
        {
            Book? book = FindBook(id);

            if (book == null)
            {
                Console.WriteLine($"Book with ID {id} was not found.");
                return;
            }

            book.Borrow();
        }

        public void ReturnBook(int id)
        {
            Book? book = FindBook(id);

            if (book == null)
            {
                Console.WriteLine($"Book with ID {id} was not found.");
                return;
            }

            book.Return();
        }

        public void PrintAvailableBooks()
        {
            Console.WriteLine($"\nAvailable books in '{Name}':");

            bool hasAvailableBooks = false;

            foreach (Book book in books)
            {
                if (!book.IsBorrowed)
                {
                    book.PrintInfo();
                    hasAvailableBooks = true;
                }
            }

            if (!hasAvailableBooks)
            {
                Console.WriteLine("No books are available.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("City Library");

            Book firstBook = new Book(
                1, "The Hobbit", "J.R.R. Tolkien");

            Book secondBook = new Book(
                2, "1984", "George Orwell");

            Book thirdBook = new Book(
                3, "The Little Prince", "Antoine de Saint-Exupery");

            library.AddBook(firstBook);
            library.AddBook(secondBook);
            library.AddBook(thirdBook);

            // Invalid additions
            library.AddBook(new Book(1, "Duplicate Book", "Test Author"));
            library.AddBook(null);

            Console.WriteLine();

            library.BorrowBook(1);
            library.BorrowBook(1);

            library.PrintAvailableBooks();

            Console.WriteLine();

            library.ReturnBook(1);
            library.ReturnBook(1);

            library.BorrowBook(999);

            library.PrintAvailableBooks();
        }
    }
}