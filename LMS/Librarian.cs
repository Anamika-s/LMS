using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    class Librarian : Person
    {
        public int AddBook(Book book) {
            Book book1 = bookList.Where(x => x.bookId == book.bookId).FirstOrDefault();
            if (book1 != null)
                return 1;
            else
            {
                bookList.Add(book);
                return 0;
            }
            
        }
        public void DeleteBook() { }
        public void EditBook() { }

    }
}
