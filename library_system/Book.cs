using System;

namespace library_system
{
    public class Book
    {
        private string name;
        private string writer;
        private string isbn;

        public Book(string name, string writer, string isbn)
        {
            this.name = name;
            this.writer = writer;
            this.isbn = isbn;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Writer
        {
            get { return writer; }
            set { writer = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string BookInformation()
        {
            return $"Kitap Adı: {name}, Yazar: {writer}, ISBN: {isbn}";
        }
    }
}
