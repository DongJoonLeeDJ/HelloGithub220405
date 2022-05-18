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
        public Form1()
        {
            InitializeComponent();
            bulba = new Bulbasaur();
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


        }
    }
}
