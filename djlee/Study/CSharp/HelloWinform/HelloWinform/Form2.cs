using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinform
{
    public partial class Form2 : Form
    {
        public List<string> list { get; set; } //멤버변수(인스턴스 변수)
        public Form2() //생성자
        {
            InitializeComponent();
            list = new List<string>(); //메모리를 할당함 
            //new 키워드가 없으면 변수 선언이 안 된 것이다.
            //그냥 null값이라서 아무 것도 아님...

            label_numbers.Text = "";
            Random rand = new Random();
            //이거 누르면 추가
            button1.Text = rand.Next(1,100).ToString();
            button2.Text = rand.Next(1,100).ToString();
            button3.Text = rand.Next(1,100).ToString();
            button4.Text = rand.Next(1,100).ToString();
            //이거 누르면 삭제
            button5.Text = button1.Text;
            button6.Text = button2.Text;
            button7.Text = button3.Text;
            button8.Text = button4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(button1.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(button2.Text);
            label_numbers.Text = ""; 
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Add(button3.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Add(button4.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Remove(button5.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Remove(button6.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Remove(button7.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list.Remove(button8.Text);
            label_numbers.Text = "";
            foreach (var item in list)
            {
                label_numbers.Text += item + " ";
            }
        }

    }
}
