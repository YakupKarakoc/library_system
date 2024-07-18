using System;
using System.Collections.Generic;

namespace library_system
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Kitap başarıyla eklendi.");
        }

        public void DeleteBook(string isbn)
        {
            Book bookToRemove = books.Find(b => b.Isbn == isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Kitap başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Kitap bulunamadı.");
            }
        }

        public void ListBooks()
        {
            Console.WriteLine("Kütüphanedeki Kitaplar:");
            foreach (Book book in books)
            {
                Console.WriteLine(book.BookInformation());
            }
        }
    }
}
