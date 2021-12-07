using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class BOOK
    {
        public int bookId;
        public string bookName;
        public string bookAuthor;
        public string bookPublisher;
        public int bookQuantity;
        public int getId()
        {
            return bookId;
        }
        public string getBook()
        {
            string bookInfo = Convert.ToString(bookId) + "\t" + bookName;
            return bookInfo;
        }
        public void addBook()
        {
            bookQuantity++;
        }
        public void borrowBook()
        {
            bookQuantity--;
        }
    }
}
