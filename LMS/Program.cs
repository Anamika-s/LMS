using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    enum role { Librarian, Member };
    class Program
    {
       
       
        static void CommonMenuForLibrarianAndMember()
        {
            Console.WriteLine("1. List of Books");
            Console.WriteLine("2. Search Book");
           
        }
            static void MenuForLibrarian()
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Delete Book");
            Console.WriteLine("3. Edit Book");

            Console.WriteLine("4. Issue Book");
        }
        static void MenuForMember()
        {
            Console.WriteLine("1. Issue Book");
            Console.WriteLine("2. Return Book");
            Console.WriteLine("3. Reissue Book");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your role");
            Console.WriteLine("1. Librarian");
            Console.WriteLine("2. Member" );
            string role = Console.ReadLine();
            Person p = new Person();
            p.InitializeBooks();
            CommonMenuForLibrarianAndMember();
            Console.WriteLine("Enter Choice");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        p = new Person();
                        List<Book> listofBooks = new List<Book>();
                        listofBooks = p.GetBookList();
                        Book book = new Book();
                        book.DisplayBookList(listofBooks);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Book Name to Search");
                        string bookName = Console.ReadLine();
                        p = new Person();
                        Book book = p.GetBookDetails(bookName);
                        if (book == null)
                        {
                            Console.WriteLine("Book not found");
                        }
                        else
                            book.DisplayBookDetails(book);
                        break;
                    }
            }

           
             
            switch(role)
            {
                case "1":
                    {
                        MenuForLibrarian();
                        Console.WriteLine("Enter choice");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Enter BookID");
                                    int bookID = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter BookName");
                                    string bookName = Console.ReadLine();
                                    Console.WriteLine("Enter author of Book");
                                    string bookAuthorName = Console.ReadLine();

                                    Console.WriteLine("Enter Book Price");
                                    int bookPrice = int.Parse(Console.ReadLine());
                                    Book book = new Book() { bookId = bookID, bookName = bookName, bookAuthorName = bookAuthorName, bookPrice = bookPrice };
                                    Librarian person = new Librarian();
                                    int flag = person.AddBook(book);
                                    if (flag == 1)
                                        Console.WriteLine("Book with this id already exist");
                                    else
                                        Console.WriteLine("Book Added");

                                    break;
                                }
                            case 2:
                                {
                                    break;
                                }
                            case 3:
                                {
                                    break;
                                }
                        }
                    }
                        break;
                    
                case "2":
                    {

                        MenuForMember();
                        Console.WriteLine("Enter choice");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    break;
                                }
                            case 2:
                                {
                                    break;
                                }
                            case 3:
                                {
                                    break;
                                }
                        }
                        break;
                    }
            }

        }
    }
}
