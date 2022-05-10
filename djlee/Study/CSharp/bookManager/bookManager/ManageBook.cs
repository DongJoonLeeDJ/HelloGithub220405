using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookManager
{
    public partial class ManageBook : Form
    {
        public ManageBook()
        {
            InitializeComponent();
            if(DataManager.Books.Count>0)
                dataGridView_books.DataSource = DataManager.Books;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            /*isbn이 겹치는 걸 원하지 않는다면 별도의 예외처리를 걸어줄 수도 있다.*/
            //Single이라는 메소드 사용(다른 곳에서 사용해볼 것임)


            //foreach문
            bool isExist = false;
            foreach(var item in DataManager.Books)
            {
                if(item.Isbn == textBox_isbn.Text)
                {
                    isExist = true;
                    break;
                }
            }

            if(isExist) //책이 이미 있다면
            {
                MessageBox.Show("해당 도서는 이미 존재합니다.");
                return; //메소드 종료
            }

            Book book = new Book(); //임의의 인스턴스를 만든다.
            book.Isbn = textBox_isbn.Text;
            book.Name = textBox_bookName.Text;
            book.Publisher = textBox_publisher.Text;
            book.Page = int.Parse(textBox_page.Text);
            DataManager.Books.Add(book);

            dataGridView_books.DataSource = null;
            dataGridView_books.DataSource = DataManager.Books;
            DataManager.Save();
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            Book book = null;
            for(int i = 0; i<DataManager.Books.Count; i++) //isbn으로 찾아서 해당 도서를 수정할 예정
            {
                if(DataManager.Books[i].Isbn == textBox_isbn.Text)
                {
                    book = DataManager.Books[i]; //Books 안에 있는 i번째 값을 "가리키게" 됨
                    book.Name = textBox_bookName.Text;
                    book.Publisher = textBox_publisher.Text;
                    book.Page = int.Parse(textBox_page.Text);

                    dataGridView_books.DataSource = null;
                    dataGridView_books.DataSource = DataManager.Books;
                    DataManager.Save();
                    break;
                }
            }
            if(book == null)
                MessageBox.Show("존재하지 않는 도서입니다.(수정불가능)");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            for(int i =0; i<DataManager.Books.Count; i++)
            {
                if (DataManager.Books[i].Isbn == textBox_isbn.Text)
                {
                    DataManager.Books.RemoveAt(i);
                    isExist = true;
                    break;
                }
            }
            //if(isExist == false)
            if(!isExist)
                MessageBox.Show("없는 책이다!");
            else
            {
                dataGridView_books.DataSource = null;
                if(DataManager.Books.Count>0)
                {
                    dataGridView_books.DataSource = DataManager.Books;
                }
                DataManager.Save();
            }
        }

        private void dataGridView_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //내가 클릭한 1줄을 Book 데이터로 변경
            Book book = dataGridView_books.CurrentRow.DataBoundItem as Book;
            textBox_isbn.Text = book.Isbn;
            textBox_bookName.Text = book.Name;
            textBox_publisher.Text = book.Publisher;
            textBox_page.Text = book.Page.ToString();
        }
    }
}
