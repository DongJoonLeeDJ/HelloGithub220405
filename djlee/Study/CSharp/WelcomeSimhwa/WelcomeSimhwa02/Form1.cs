using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WelcomeSimhwa02
{
    public delegate void EmptyFunction();
    public delegate void TestFunc(EmptyFunction f, int c);

    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public void testExecute(TestFunc t, EmptyFunction f, int count)
        {
            for (int i = 0; i < count; i++)
                t(f,count);
        }
        public void sayHello()
        {
            MessageBox.Show("안녕하세요.");
        }
        public void executeFunc(EmptyFunction f, int count)
        {
            for (int i = 0; i < count; i++)
                f();
        }
        public Form1()
        {
            InitializeComponent();
            students.Add(new Student() {Id=10,Name="문찬호",Age=34 });
            students.Add(new Student() {Id=3,Name="이동준",Age=33 });
            students.Add(new Student() {Id=3,Name="손진표",Age=33 });
            students.Add(new Student() {Id=3,Name="안성욱",Age=33 });
            students.Add(new Student() {Id=5,Name="한준범",Age=32 });
            students.Add(new Student() {Id=7,Name="이운복",Age=21 });
            students.Add(new Student() {Id=7,Name="박나은",Age=11 });
            students.Add(new Student() {Id=7,Name="정병주",Age=1 });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayHello();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                executeFunc(sayHello, int.Parse(textBox1.Text));
            }
            catch (Exception)
            {
                MessageBox.Show(textBox1+"은 잘못된 값...!");
                executeFunc(sayHello, 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //무명 델리게이트
            executeFunc(delegate () { MessageBox.Show("ㅁㅁ"); }, 3);

            //람다
            executeFunc(() => MessageBox.Show("ㅠㅠ"), 3) ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            testExecute(executeFunc, sayHello, 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            students.Sort(delegate (Student a, Student b)
            {
                return a.Age.CompareTo(b.Age);
            });

            label1.Text = "";
            foreach(Student a in students)
            {
                label1.Text += a.ToString() + Environment.NewLine;
            }
        }

        private int myCompare(Student a, Student b)
        {
            return a.Id.CompareTo(b.Id);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // students.Sort((a,b)=>a.Id.CompareTo(b.Id));
            students.Sort(myCompare);
            label2.Text = "";
            foreach (Student a in students)
            {
                label2.Text += a.ToString() + Environment.NewLine;
            }
        }




        private void mytest()
        {
            for(int i = 0; i<100;i++)
                Console.Write("c");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //Thread
            //실행단위인데, 비동기방식
            //시분할 시스템을 이용함
            //컴퓨터나 인간이나
            //같은 시간에 동시에 한 가지 일 밖에 못하지만
            //하나의 일을 하다가 그 일이 좀 막히면 그 다음 일을 하는 방식으로
            //주어진 작업들을 모두 처리하는 방식
            Console.Clear(); //콘솔 화면 지우기
            Thread a = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                    Console.Write("A");
            });
            Thread b = new Thread(delegate () 
            {
                for (int i = 0; i < 100; i++)
                    Console.Write("B");
            });
            Thread c = new Thread(mytest);

            a.Start();
            b.Start();
            c.Start();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xe = XElement.Load(url);
            var xQuery = from item in xe.Descendants("data") select item;
            foreach(var item in xQuery)
            {
                Console.WriteLine(item);
            }

            var xQuery2 = from item in xe.Descendants("data") select new
            {
                hour = item.Element("hour").Value,
                WfKor = item.Element("wdKor").Value,
                WfEn = item.Element("wfEn").Value
            };
            foreach (var item in xQuery2)
            {
                Console.WriteLine(item.hour);
                Console.WriteLine(item.WfKor);
                Console.WriteLine(item.WfEn);
            }
            var xQuery3 = from item in xe.Descendants("data")
                          select new Weather()
                          {
                              hour = item.Element("hour").Value,
                              Kor = item.Element("wfKor").Value,
                              Eng = item.Element("wfEn").Value
                          };
            foreach (var item in xQuery3)
            {
                Console.WriteLine(item.hour);
                Console.WriteLine(item.Kor);
                Console.WriteLine(item.Eng);
            }
        }
    }
}
