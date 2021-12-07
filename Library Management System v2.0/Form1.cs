using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_v2._0
{
    public partial class libraryManagementSystemV2 : Form
    {
        List<STUDYBOOK> studyBooks = new List<STUDYBOOK>();
        List<RESEARCHARTICLE> researchArticles = new List<RESEARCHARTICLE>();
        public libraryManagementSystemV2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addStudyBookButton_Click(object sender, EventArgs e)
        {
            string id = addBookIdTextBox.Text;
            string title = addBookTitleTextBox.Text;
            string author = addResearchAuthorTextBox.Text;
            string publisher = addBookPublisherTextBox.Text;
            int quantity = Convert.ToInt32(addBookQuantityTextBox.Text);
            string isbn = addBookIsbnTextBox.Text;
            string genre = addBookGenreTextBox.Text;

            STUDYBOOK dummyStudyBook = new STUDYBOOK();
            dummyStudyBook.bookId = id;

            dummyStudyBook.bookName = title;
            dummyStudyBook.bookAuthor = author;
            dummyStudyBook.bookPublisher = publisher;
            dummyStudyBook.bookQuantity += quantity;
            dummyStudyBook.bookIsbn = isbn;
            dummyStudyBook.bookGenre = genre;
            
            
                studyBooks.Add(dummyStudyBook);
                MessageBox.Show("Successfully Saved Study Book.");
            

        }

        private void addResearchBookButton_Click(object sender, EventArgs e)
        {
            string id = addResearchIdTextBox.Text;
            string title = addResearchTitleTextBox.Text;
            string author = addResearchAuthorTextBox.Text;
            string publisher = addResearchPublisherTextBox.Text;
            int quantity = Convert.ToInt32(addResearchQuantityTextBox.Text);
            string doi = addResearchDoiTextBox.Text;
            string publish = addResearchPublishTextBox.Text;
            string cOrJ = addConferenceJournalTextBox.Text;

            RESEARCHARTICLE dummyArticle = new RESEARCHARTICLE();
            dummyArticle.bookId = id;

            dummyArticle.bookName = title;
            dummyArticle.bookAuthor = author;
            dummyArticle.bookPublisher = publisher;
            dummyArticle.bookQuantity += quantity;
            dummyArticle.articleDoi = doi;
            dummyArticle.publishedDate = publish;
            dummyArticle.conferenceOrJournal = cOrJ;


            researchArticles.Add(dummyArticle);
            MessageBox.Show("Successfully Saved Article.");
        }

        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            string id = borrowBookIdTextBox.Text;
            bool book_exists = false;
            for (int i = 0; i < studyBooks.Count; i++)
            {
                if (id == studyBooks[i].bookId)
                {
                    studyBooks[i].borrow();
                    book_exists = true;
                    MessageBox.Show("Book Borrowed Successfully.");
                    

                }
            }
                if (!book_exists)
                {
                    MessageBox.Show("Book Not Available.");
                }
        }

        private void borrowArticleButton_Click(object sender, EventArgs e)
        {
            string id = borrowArticleIdTextBox.Text;
            bool article_exists = false;
            for (int i = 0; i < researchArticles.Count; i++)
            {
                if (id == researchArticles[i].bookId)
                {
                    researchArticles[i].borrow();
                    article_exists = true;
                    MessageBox.Show("Article Borrowed Successfully.");
                    

                }
            }
                if (!article_exists)
                {
                    MessageBox.Show("Article Not Available.");
                }
        }

        private void showBooksButton_Click(object sender, EventArgs e)
        {
            booklist.Items.Clear();
            for (int i = 0; i < studyBooks.Count; i++)
            {

                booklist.Items.Add(studyBooks[i].getInfo());    

                
            }
        }

        private void showArticlesButton_Click(object sender, EventArgs e)
        {
            articlelist.Items.Clear();
            for (int i = 0; i < researchArticles.Count; i++)
            {

                articlelist.Items.Add(researchArticles[i].getInfo());


            }
        }

        private void articlelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
