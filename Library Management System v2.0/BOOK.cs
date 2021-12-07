using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v2._0
{
    internal class BOOK
    {
        public string bookId;
        public string bookName;
        public string bookAuthor;
        public string bookPublisher;
        public int bookQuantity;

        public void borrow()
        {
            bookQuantity--;
        }
    }
    class STUDYBOOK : BOOK
    {
        public string bookIsbn;
        public string bookGenre;
        public string getInfo()
        {
            string showBook = bookId + "\t\t" + bookName + "\t\t" + bookAuthor + "\t\t" + bookIsbn +"\t\t" + Convert.ToString(bookQuantity);
            return showBook;
        }
    }
    class RESEARCHARTICLE : BOOK
    {
        public string articleDoi;
        public string publishedDate;
        public string conferenceOrJournal;
        public string getInfo()
        {
            string showArticle = bookId + "\t\t" + bookName + "\t\t" + bookAuthor + "\t\t" + articleDoi +"\t\t" + Convert.ToString(bookQuantity) +"\t\t"+ conferenceOrJournal;
            return showArticle;
        }
    }
}
