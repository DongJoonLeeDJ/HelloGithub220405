using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeyWindowform
{
    public partial class Form1 : Form
    {
        public void sayHello()
        {
            MessageBox.Show("Hello!!!");
        }
        public Form1() //생성자
        {
            InitializeComponent(); //메소드(private void InitializeComponent())
        }

        //버튼을 클릭했을 때, 호출하는 메소드
        
        private void sayHello(object sender, EventArgs e)
        {
            sayHello();//Form1 클래스에 새로 추가한 메소드
        }
    }
}
