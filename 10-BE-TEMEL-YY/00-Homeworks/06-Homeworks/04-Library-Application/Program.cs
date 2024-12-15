using System;
using System.Collections.Generic;

namespace _04_Library_Application
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; private set; } = false;
        public Book(string title, string author, int pages, string isbn)
        {
            Title = title;
            Author = author;
            Pages = pages;
            ISBN = isbn;
        }

        public void Borrow()
        {
            if (!IsBorrowed)
            {
                IsBorrowed = true;
                Console.WriteLine($"{Title} kitabı ödünç aldınız.");
            }
            else
            {
                Console.WriteLine($"{Title} kitabı zaten ödünç alınmış.");
            }
        }

        public void Return()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                Console.WriteLine($"{Title} kitabı iade edildi.");
            }
            else
            {
                Console.WriteLine($"{Title} kitabı zaten kütüphanede.");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Başlık: {Title} - Yazar: {Author} - Sayfa Sayısı: {Pages} - ISBN: {ISBN} - Durum: {(IsBorrowed ? "Ödünç alınmış" : "Kütüphanede")}");
        }
    }

    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"{book.Title} kütüphaneye eklendi.");
        }

        public void ListBooks()
        {
            Console.WriteLine("Kütüphanedeki kitaplar:");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }
        }

        public Book FindBookByISBN(string isbn)
        {
            return books.Find(book => book.ISBN == isbn);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("Savaş ve Barış", "Lev Tolstoy", 1225, "978-3-16-148410-0");
            Book book2 = new Book("1984", "George Orwell", 328, "978-0-452-28423-4");

            library.AddBook(book1);
            library.AddBook(book2);

            library.ListBooks();
            Console.WriteLine();


            book1.Borrow();
            book1.Borrow(); // Zaten ödünç alınmış
            book1.Return();
            book1.Return(); // Zaten iade edilmiş

            Console.WriteLine();

            Book foundBook = library.FindBookByISBN("978-0-452-28423-4");
            if (foundBook != null)
            {
                Console.WriteLine("Kitap Bulundu:");
                foundBook.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Kitap bulunamadı.");
            }
        }
    }
}
