using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomeSimhwa
{
    public partial class Form1 : Form
    {
        Bulbasaur bulba;
        List<Product> products = new List<Product>(); //DataSource를 이 리스트로 바꾸는 것도 가능함
        public Form1()
        {
            InitializeComponent();
            bulba = new Bulbasaur();

            productBindingSource.Add(new Product() { Name = "감자", Price = 500 });
            productBindingSource.Add(new Product() { Name = "고구마", Price = 5000 });
            productBindingSource.Add(new Product() { Name = "자색고구마", Price = 1500 });
            productBindingSource.Add(new Product() { Name = "김치", Price = 3000 });

            comboBox1.SelectedIndexChanged += DataSelect;
            listBox1.SelectedIndexChanged += DataSelect;

            bindingSource1.Add(new Student() { name = "이동준", num = 1, score = 70 });
            bindingSource1.Add(new Student() { name = "정병주", num = 2, score = 80 });
            bindingSource1.Add(new Student() { name = "이운복", num = 3, score = 90 });

        }

        private void DataSelect(object sender, EventArgs e)
        {
            if(sender is ComboBox)
            {
                ComboBox cbx = sender as ComboBox;
                Product p = cbx.SelectedItem as Product; //내가 선택한 걸 Product타입으로 변경
                MessageBox.Show(cbx.SelectedValue.ToString()); //선택한 것의 값
                MessageBox.Show(p.ToString());
            }
            else if(sender is ListBox)
            {
                ListBox cbx = sender as ListBox;
                Product p = cbx.SelectedItem as Product; //내가 선택한 걸 Product타입으로 변경
                MessageBox.Show(cbx.SelectedValue.ToString()); //선택한 것의 값
                MessageBox.Show(p.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int.TryParse(textBox2.Text, out int age);
            int.TryParse(textBox3.Text, out int leafPower);
            int.TryParse(textBox4.Text, out int venomPower);

            bulba.masterName = name;
            bulba.age = age;
            bulba.leafPower = leafPower;
            bulba.venomPower = venomPower;

            MessageBox.Show("이상해씨 완성");
            string result = $"트레이너명:{bulba.masterName},";
             result += $"나이:{bulba.age},";
             result += $"풀공격력:{bulba.leafPower},";
             result += $"독공격력:{bulba.venomPower}";
            MessageBox.Show(result);


            //왼쪽은 조상클래스 아니면 인터페이스
            //오른쪽 자손 클래스 혹은 해당 인터페이스를 구현한 클래스
            //다형성
            //이걸 응용해서 Animal 배열 혹은 IPlant List나 IPoision List 만들 수 있음
            Animal a1 = new Bulbasaur();
            IPlant p1 = new Bulbasaur();
            IPoision p2 = new Bulbasaur();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            bulba.attack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bulba.charming();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bulba.leafstorm();
            bulba.leafcutter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bulba.venomBom();
            bulba.venomShork();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[] { 10, 5, 1, 30, 15 };
            Student[] students = new Student[3];
            students[0] = new Student() {name="이동준",num=1,score=80 };
            students[1] = new Student() { name = "문찬호", num = 2, score = 100 };
            students[2] = new Student() { name = "한준범", num = 3, score = 90 };

            Array.Sort(numbers);
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }
            Array.Sort(students);
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            products.Add(new Product() {Name="포켓몬게임", Price=50000 });
            products.Add(new Product() {Name="포켓몬빵", Price=1550000 });
            products.Add(new Product() {Name="포켓몬스티커", Price=15500 });
            comboBox1.DataSource = null;
            comboBox1.DataSource = products;

            listBox1.DataSource = null;
            listBox1.DataSource = products;
        }
    }
}
