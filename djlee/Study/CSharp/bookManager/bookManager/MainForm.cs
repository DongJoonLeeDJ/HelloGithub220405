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
            
            refreshScreen();
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
            
            label_allBorrowedBook.Text 
                = DataManager.Books.Where(delegate (Book x) { return x.isBorrowed; }).Count().ToString();

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
        }
    }
}
