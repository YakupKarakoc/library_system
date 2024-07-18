using System;

namespace library_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("****************** Kütüphane Yönetim Sistemi ******************");
                Console.WriteLine("1-Kitap Ekle\n2-Kitap Sil\n3-Kitapları Listele\n4-Çıkış\n");
                Console.WriteLine("Lütfen yapmak istediğiniz seçimi giriniz : ");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Lütfen eklemek istediğiniz kitabın adını girin :");
                        string name = Console.ReadLine();
                        Console.WriteLine("Lütfen eklemek istediğiniz kitabın yazarını girin :");
                        string writer = Console.ReadLine();
                        Console.WriteLine("Lütfen eklemek istediğiniz kitabın ISBN numarasını girin : ");
                        string isbn = Console.ReadLine();
                        Book newBook = new Book(name, writer, isbn);
                        library.AddBook(newBook);
                        break;

                    case "2":
                        Console.WriteLine("Lütfen silmek istediğiniz kitabın ISBN numarasını giriniz : ");
                        string isbnToDelete = Console.ReadLine();
                        library.DeleteBook(isbnToDelete);
                        break;

                    case "3":
                        library.ListBooks();
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Lütfen 1-4 arasında seçim giriniz.");
                        break;
                }
            }
        }
    }
}
