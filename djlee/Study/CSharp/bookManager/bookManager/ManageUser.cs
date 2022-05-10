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
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
