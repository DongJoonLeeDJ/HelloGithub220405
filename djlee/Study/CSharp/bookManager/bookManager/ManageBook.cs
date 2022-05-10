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

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
