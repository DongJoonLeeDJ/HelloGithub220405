using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinform02
{
    public partial class Form1 : Form
    {
        enum 가위바위보
        {
            가위,바위,보
        }


        int num;
        public Form1()
        {
            InitializeComponent();
            num = new Random().Next(1, 10); //1부터 9까지의 값 중 하나 입력
            Console.WriteLine("정답:"+num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer = int.Parse(textBox_num1.Text);
            if(answer==num)
            {
                MessageBox.Show("정답!");
                num = new Random().Next(1, 10);
                Console.WriteLine("정답:"+num);
            }
            else //틀리면 정답을 알려줌
            {
                MessageBox.Show("정답은 " + num + "입니다.");
            }
        }

        private void button_gawi_Click(object sender, EventArgs e)
        {
            //가위 바위 보는 서로 값을 비교하는 것이 불가능
            //컴퓨터는 0,1,2 셋중 하나의 값을 가져올거고 0=가위, 1=바위 , 2=보로 가정할 것
            int computer = new Random().Next(3); //0,1,2 셋중 하나의 값을 낸다.
            Console.WriteLine(computer);

            switch (computer)
            {
                case 0: //가위
                    MessageBox.Show("비김");
                    break;
                case 1: //바위
                    MessageBox.Show("짐");
                    break;
                case 2: //보
                    MessageBox.Show("이김");
                    break;
                default:
                    break;
            }
        }

        private void button_bawi_Click(object sender, EventArgs e)
        {
            int computer = new Random().Next(3); //0,1,2 중 하나의 값을 리턴
            string[] rsp = new string[] { "가위", "바위", "보" };
            string computerResult = rsp[computer]; //computer값에 따라 달라지는 computerResult
            switch (computerResult)
            {
                case "가위":
                    MessageBox.Show("이김");
                    break;
                case "바위":
                    MessageBox.Show("비김");
                    break;
                case "보":
                    MessageBox.Show("짐");
                    break;
                default:
                    break;
            }
        }

        private void button_bo_Click(object sender, EventArgs e)
        {
            int computer = new Random().Next(3);
            switch (computer)
            {
                case (int)가위바위보.가위:
                    MessageBox.Show("짐");
                    break;

                case (int)가위바위보.바위:
                    MessageBox.Show("이김");
                    break;

                case (int)가위바위보.보:
                    MessageBox.Show("비김");
                    break;

                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] sentense = new string[] {"티끌 모아 태산","가는 말이 고와야 오는 말도 곱다", "늘 웃자" };
            List<string> sentenseList = new List<string>();
            sentenseList.Add("역지사지");
            sentenseList.Add("유유상종");
            sentenseList.Add("일어탁수");

            string s = sentense[new Random().Next(sentense.Length)];
            string s2 = sentenseList[new Random().Next(sentenseList.Count)];

            label_num3.Text = s + Environment.NewLine + s2;
            //s+"\n"+s2
            //Environment.NewLine = \n이랑 똑같음
            //운영체제에 따라서 개행문자가 다른 데, 그걸 이용한 것
        }
    }
}
