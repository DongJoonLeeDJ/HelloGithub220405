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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
            if (DataManager.Users.Count > 0)
                dataGridView_Users.DataSource = DataManager.Users;

            //셀을 눌렀을 때 이벤트 추가하는 거를 코드상에서 해보기
            dataGridView_Users.CellClick += mycellClick;
        }

        private void mycellClick(object sender, DataGridViewCellEventArgs e)
        {
            User u = dataGridView_Users.CurrentRow.DataBoundItem as User;
            textBox_id.Text = u.Id.ToString();
            textBox_name.Text = u.Name;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //숫자 0은 임의의 값이고, Books에서 userId가 없을 때 나타내는 임의의 값이므로
            //0은 Id로 쓰지 않는다.
            if(int.Parse(textBox_id.Text) ==0)
            {
                MessageBox.Show("잘못된 ID입니다.");
                return;
            }

            //해당 id 존재하는지 여부 체크 Exists
            if(DataManager.Users.Exists(x=>x.Id == int.Parse(textBox_id.Text)))
            {
                MessageBox.Show("해당 ID 유저 이미 존재");
            }
            else
            {
                User u = new User() { Id=int.Parse(textBox_id.Text), Name=textBox_name.Text };
                DataManager.Users.Add(u);
                dataGridView_Users.DataSource = null;
                dataGridView_Users.DataSource = DataManager.Users;
                DataManager.Save();
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            //Single사용
            //Single : List에서 조건을 만족하는 인스턴스 하나를 가리키는 것
            //조건을 만족하는 것이 List안에 없으면 catch부분으로 빠짐(에러를 throw)
            try
            {
                User user = DataManager.Users.Single(x => x.Id == int.Parse(textBox_id.Text));
                user.Name = textBox_name.Text;

                //만약에 해당 유저가 책을 빌린 유저였다면, Books의 userName정보도 같이 바꿔야 됨
                try
                {
                    Book book = DataManager.Books.Single(x => x.UserId == int.Parse(textBox_id.Text));
                    book.UserName = textBox_name.Text;
                }
                catch (Exception) //해당 유저가 책을 안 빌렸을 수도 있으니까 없으면 냅둔다.
                {
                }

                dataGridView_Users.DataSource = null;
                dataGridView_Users.DataSource = DataManager.Users;
                DataManager.Save();

            }
            catch (Exception)
            {
                MessageBox.Show("이 아이디는 없는 유저입니다.");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
