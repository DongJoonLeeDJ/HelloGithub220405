using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3조_팀프로젝트3
{
    public partial class Form4 : Form
    {
        OracleConnection oracleConnection;
        public Form4()
        {
            InitializeComponent();
#pragma warning disable CS0618 // Type or member is obsolete
            oracleConnection = new OracleConnection("Data Source=192.168.0.31;User ID=team3;Password=1234;Unicode=True");
#pragma warning restore CS0618 // Type or member is obsolete
        }

        private void open_conn()
        {
            if (oracleConnection.State == ConnectionState.Closed) oracleConnection.Open();
        }

        private void grid()
        {
            OracleDataAdapter da;
            DataSet ds;
            ds = new DataSet();
            string query;

            query = "Select * from 사업장";
            da = new OracleDataAdapter(query, oracleConnection);
            da.Fill(ds, "사업장");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "사업장";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            grid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["업주번호"].Value.ToString() == "")
            {
                MessageBox.Show("first", "second", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["업주번호"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["사업장이름"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["사업장주소"].Value.ToString();
            }
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            grid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd;
            string query = "";
            int row;

            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter("select * from 사업장 where 업주번호 = '" + textBox1.Text + "'", oracleConnection);
            row = da.Fill(ds, "사업장");

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("빈칸이 있습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else
            {
                if (row == 0)
                {
                    if (MessageBox.Show("입력하겠습니까? ", "입력", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        query = "insert into 사업장(업주번호, 사업장이름, 사업장주소) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +"')";
                        MessageBox.Show("입력되었습니다");
                    }

                }
                else
                {
                    query = "update 사업장 set 사업장이름 = '" + textBox2.Text + "',사업장주소 = '" + textBox3.Text + "' where 업주번호 = '" + textBox1.Text + "'";
                    MessageBox.Show("갱신되었습니다");
                }
                cmd = new OracleCommand();
                open_conn();
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = oracleConnection;
                    row = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    textBox1.Focus();
                }
                grid();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd;
            string de = "delete from 사업장 where 업주번호 = '" + textBox1.Text + "'";
            if (textBox1.Text == "") MessageBox.Show("delete!");
            if (MessageBox.Show("삭제하겠습니까? ", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                open_conn();
                cmd = new OracleCommand();
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = de;
                    cmd.Connection = oracleConnection;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    textBox1.Focus();
                }
            }
            grid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
