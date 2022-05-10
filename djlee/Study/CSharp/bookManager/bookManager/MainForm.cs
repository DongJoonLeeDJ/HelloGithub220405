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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //대문자 M : month(월)
            //소문자 m : minute(분)
            label_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");

            //익명 델리게이트
            dataGridView_bookManager.CellClick += delegate (object s, DataGridViewCellEventArgs e)
            {
                Book book = dataGridView_bookManager.CurrentRow.DataBoundItem as Book;
                textBox_isbn.Text = book.Isbn;
                textBox_bookName.Text = book.Name;
            };

            //람다
            dataGridView_userManager.CellClick += (s,e) =>
            {
                User user = dataGridView_userManager.CurrentRow.DataBoundItem as User;
                textBox_id.Text = user.Id.ToString();
            };

            //대여
            button_borrow.Click += Button_borrow_Click;

            //반납
            button_return.Click += Button_return_Click;

            refreshScreen();
        }

        private void Button_return_Click(object sender, EventArgs e)
        {
            if (textBox_isbn.Text.Trim() == "") //Trim : 양 옆의 공백 제거
                MessageBox.Show("isbn값 입력해요");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single(x => x.Isbn == textBox_isbn.Text);
                    if(book.isBorrowed)
                    {
                        DateTime oldDay = book.BorrowedAt; 
                        book.UserId = 0;
                        book.UserName = "";
                        book.isBorrowed = false;
                        book.BorrowedAt = new DateTime(); //0001년과 같은 비어있는 값

                        DataManager.Save();
                        refreshScreen();

                        //연체여부 체크
                        TimeSpan timeDiff = DateTime.Now - oldDay;
                        if(timeDiff.Days>7)
                            MessageBox.Show(book.Name+"은 연체 상태로 반납");
                        else
                            MessageBox.Show(book.Name+"은 정상반납");
                    }
                    else
                    {
                        MessageBox.Show("대여 상태 아닙니다.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("없는 책입니다.");
                }
            }
            //throw new NotImplementedException();
        }

        private void Button_borrow_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if(textBox_isbn.Text.Trim() == "") //Trim : 양 옆의 공백 제거
                MessageBox.Show("isbn값 입력해요");
            else if(textBox_id.Text.Trim()=="")
                MessageBox.Show("사용자 id 입력해요");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single(x => x.Isbn == textBox_isbn.Text);
                    if(book.isBorrowed)
                    {
                        MessageBox.Show("이미 빌렸습니다!");
                        return;
                    }
                    User user = DataManager.Users.Single(x => x.Id.ToString() == textBox_id.Text);
                    book.UserId = user.Id;
                    book.UserName = user.Name;
                    book.isBorrowed = true;
                    book.BorrowedAt = DateTime.Now;
                    DataManager.Save();

                    refreshScreen();

                    MessageBox.Show($"{book.Name}이/가 {user.Name}님께 대여되었습니다.");
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서 혹은 사용자!!!");
                }
            }
        }

        private bool selectBorrowed(Book temp)
        {
            return temp.isBorrowed;
        }

        private void refreshScreen()
        {
            label_allBookCount.Text = DataManager.Books.Count.ToString(); //이 때 Load호출
            //static이 붙은 생성자는 단 한 번만 호출함
            label_allUserCount.Text = DataManager.Users.Count.ToString(); //이 때는 Load는 호출 안 함

            //델리게이트 or 람다를 알아야지만 이해할 수 있는 코드
            //label_allBorrowedBook.Text = DataManager.Books.Where(x => x.isBorrowed).Count().ToString();

            //label_allBorrowedBook.Text 
            //    = DataManager.Books.Where(delegate (Book x) { return x.isBorrowed; }).Count().ToString();

            //메소드를 매개변수로 추가할 수 있음!!!
            label_allBorrowedBook.Text = DataManager.Books.Where(selectBorrowed).Count().ToString();


            //연체된 책의 수 반환
            label_allDelayedBook.Text
                = DataManager.Books.Where(x => x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now).Count().ToString();

            dataGridView_bookManager.DataSource = null;
            dataGridView_userManager.DataSource = null;

            if (DataManager.Books.Count > 0) //if문을 걸어주는 이유는 Books의 길이가 0인데, DataSource를 Books로 하면 버그생김
                dataGridView_bookManager.DataSource = DataManager.Books;
            if (DataManager.Users.Count > 0)
                dataGridView_userManager.DataSource = DataManager.Users;
        }



        private void timer_now_Tick(object sender, EventArgs e)
        {
            label_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show : 화면을 띄우고 밑에 코드들도 순차적으로 모두 실행, 모달리스(Modeless)
            //ShowDialog : 모달(Modal), 코드가 여기서 멈추고, 다른 화면 못 건드림

            new ManageBook().ShowDialog();//화면이 나타난다. 코드가 여기서 멈춤
            refreshScreen();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageUser().ShowDialog();
            refreshScreen();
        }
    }
}
