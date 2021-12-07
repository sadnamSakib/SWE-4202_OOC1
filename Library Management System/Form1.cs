using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {

        List<USER> users = new List<USER>();
        List<BOOK> books = new List<BOOK>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(newUserIdTextBox.Text);
            string name = newUserNameTextBox.Text;
            string Address = newUserAddressTextBox.Text;
            

            USER dummy_user = new USER();
            dummy_user.userId = id;

            dummy_user.userAddress = Address;
            dummy_user.userName = name;
            bool flag = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (id == users[i].userId)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                MessageBox.Show("User already exists.");
            }
            else
            {
                users.Add(dummy_user);
                MessageBox.Show("Successfully Saved");
            }

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(newBookIdTextBox.Text);
            string name = newBookNameTextBox.Text;
            string author = newBookAuthorTextBox.Text;
            string publisher = newBookPublisherTextBox.Text;
            int quantity = Convert.ToInt32(newBookQuantityTextBox.Text);

            BOOK dummy_book = new BOOK();
            dummy_book.bookId = id;

            dummy_book.bookName = name;
            dummy_book.bookAuthor = author;
            dummy_book.bookPublisher = publisher;
            dummy_book.bookQuantity += quantity;
            books.Add(dummy_book);
            MessageBox.Show("Successfully Saved.");

        }

        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(userIdBorrowTextBox.Text);
            int bookId = Convert.ToInt32(bookIdBorrowTextBox.Text);

            bool user_exists = false;
            bool book_exists = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (userId == users[i].userId)
                {
                    user_exists = true;
                }
            }
            for (int i = 0; i < books.Count; i++)
            {
                if (bookId == books[i].bookId && books[i].bookQuantity > 0)
                {
                    book_exists = true;
                }
            }
            int borrowed_book;
            if(user_exists == true && book_exists== true)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (bookId == books[i].bookId)
                    {
                        books[i].borrowBook();
                        borrowed_book= books[i].getId();
                        
                    }
                }
                for (int i = 0; i < users.Count; i++)
                {
                    if (userId == users[i].userId)
                    {
                        users[i].borrowBook(bookId);
                    }
                }
                MessageBox.Show("Book Borrowed");

            }
            else if(book_exists==false)
            {
                MessageBox.Show("Book not available.");
            }
            else
            {
                MessageBox.Show("Invalid user ID.");
            }

        }

        private void showUSerButton_Click(object sender, EventArgs e)
        {
            showBookListBox.Items.Clear();
            int id = Convert.ToInt32(showUserTextBox.Text);
            for (int i = 0; i < users.Count; i++)
            {
                if (id == users[i].userId)
                {
                    for(int j = 0; j < users[i].borrowedBooks.Count; j++)
                    {
                       for(int k = 0; k < books.Count; k++)
                        {
                            if (users[i].borrowedBooks[j] == books[k].bookId)
                            {
                                showBookListBox.Items.Add(books[k].getBook());
                            }
                        }
                    }
                }
            }
        }

        private void showBookButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(showBookTextBox.Text);
            for (int k = 0; k < books.Count; k++)
            {
                if (id==books[k].bookId)
                {
                    bookQuantityLabel.Text = "QUANTITY : "+ Convert.ToString(books[k].bookQuantity);
                    idLabel.Text = "ID : "+Convert.ToString(books[k].bookId);
                    nameLabel.Text = "NAME : " + books[k].bookName;
                    authorLabel.Text = "AUTHOR : " + books[k].bookAuthor;
                    publisherLabel.Text = "PUBLISHER : " +books[k].bookPublisher;
                    
                   

                }
            }
        }
    }
}
