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
    public partial class Form1 : Form
    {
        //생성자
        public Form1()
        {
            InitializeComponent(); //디자인창에 있는 것들을 불러들임
            button1.Text = "버튼일";

            Car c = new Car();
            c.Name = "자동차";

            Random r = new Random();
            button2.Text = r.Next(1, 11).ToString(); //1이상 11미만의 숫자가
            //button2에 적히게 됨

            //코드상에서 인위적으로 새로 만든 것
            Button b = new Button();
            Controls.Add(b);  //Controls = Form1 안에 들어가는 모든 컴포넌트들
            //(컴포넌트란 말이랑 컨트롤이란 말은 거의 유사)
            //그 안에 버튼을 새로 만들어서 넣는 것
            b.Location = new Point(150, 150);
            b.Text = "디자인엔 없음";
            b.AutoSize = true;

            //Controls 배열 같은 것
            //Form1 안에 있는 모든 것들이 담겨있는 것
            //Button, Label, TextBox 등등....

            foreach (var item in Controls)
            {
                Console.WriteLine(item.ToString());
            }

            //List는 Controls처럼 배열같은 것
            List<int> numbers = new List<int>();//처음에 선언시 크기를 정하지 않음

            numbers.Add(10);
            numbers.Add(200);

            //배열 
            //처음에 크기를 지정하고, 정해진 인덱스에 값을 넣음

            //List(=Controls도 이거랑 유사)
            //Add 라는 걸 이용해서 값을 추가

            numbers.RemoveAt(0);
            //제거도 가능
            //제거하면 그 만큼 크기가 줄어들음

            numbers.Add(300);
            numbers.Add(400);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            int sum = 0;
            for(int i = 0; i<numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("sum="+sum);

        }

        //이벤트 추가됨
        private void button1_Click(object sender, EventArgs e)
        {
            //mbox 탭탭
            MessageBox.Show("다들 잘 듣고 있죠?");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form2().Show(); //Form2가 나타남
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.Name = textBox_name.Text;
            Car.companyName = textBox_company.Text;

            MessageBox.Show(c.Name+":"+Car.companyName);
            MessageBox.Show("차의 총 개수 : " + Car.Count);
            //3대인 이유
            //Program.cs
            // public Form1()
            //button5_Click 
            //여기서 Car를 만들어왔기 때문에 Count값이 누적됨
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.Name = textBox_name.Text;
            Car.companyName = textBox_company.Text;

            MessageBox.Show(c.Name + ":" + Car.companyName);
            MessageBox.Show("차의 총 개수 : " + Car.Count);
            //Program.cs
            // public Form1()
            //button5_Click 
            //여기서 Car를 만들어왔기 때문에 Count값이 누적됨
        }
    }
}
