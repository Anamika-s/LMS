using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    class Person
    {
        public int personId { get; set; }
        public string personName { get; set; }
        public string personAddress { get; set; }

        public static List<Book> bookList;
        //{ get; set; }
        public Person() {  }
        public Person(int personId, string personName, string personAddress)
        {
            this.personId = personId;
            this.personName = personName;
            this.personAddress = personAddress;
        }
        public void InitializeBooks()
        {
            bookList = new List<Book>() { 

                new Book() { bookId = 1, bookName = "C++", bookAuthorName = "Ajay", bookPrice = 900, bookPublishDate = "12/12/2019", bookStatus = true, Genre = genre.drama },
                new Book() { bookId = 2, bookName = "C", bookAuthorName = "Ajay", bookPrice = 900, bookPublishDate = "12/12/2019", bookStatus = true, Genre = genre.programming },

                new Book() { bookId = 3, bookName = "Java", bookAuthorName = "Ajay", bookPrice = 900, bookPublishDate = "12/12/2019", bookStatus = true, Genre = genre.programming },

                new Book() { bookId = 4, bookName = "PHP", bookAuthorName = "Ajay", bookPrice = 900, bookPublishDate = "12/12/2019", bookStatus = true, Genre = genre.religious },

                new Book() { bookId = 5, bookName = "Angular", bookAuthorName = "Ajay", bookPrice = 900, bookPublishDate = "12/12/2019", bookStatus = true, Genre = genre.story }

        };
        }
        public List<Book> GetBookList()
        {
           //bookList = (from temp in bookList
           //             select temp).ToList();
            return bookList;
        }

        public Book GetBookDetails(string bookName) 
        {
            //Book book = (from temp in bookList
            //             where temp.bookName == bookName
            //             select temp).First();
                         
            Book book= bookList.Where(x => x.bookName == bookName).FirstOrDefault();
            return book;
        }

    }
}
