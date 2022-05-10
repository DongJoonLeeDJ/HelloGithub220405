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

            label_allBookCount.Text = DataManager.Books.Count.ToString(); //이 때 Load호출
            //static이 붙은 생성자는 단 한 번만 호출함
            label_allUserCount.Text = DataManager.Users.Count.ToString(); //이 때는 Load는 호출 안 함
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            label_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageBook().ShowDialog();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageUser().ShowDialog();
        }
    }
}
