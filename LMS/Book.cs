using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    enum genre {drama, story, religious, programming };
    class Book
    {
        public int bookId { get; set; }
        public string bookName { get; set; }
        public string bookAuthorName { get; set; }
        public string bookPublishDate { get; set; }
        public int bookPrice { get; set; }
        public bool bookStatus { get; set; }
        public genre Genre { get; set; }

        public void DisplayBookList(List<Book> books)

        {
                foreach(Book temp in books)
            {
                Console.WriteLine("{0} \t {1} \t  {2} \t  {3} \t" ,  temp.bookId, temp.bookName, temp.bookAuthorName, temp.bookPublishDate);
                
            }
        }

        public void DisplayBookDetails(Book book)

        {
           
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t", book.bookId, book.bookName, book.bookAuthorName, book.bookPublishDate);

            
        }
    }
}
