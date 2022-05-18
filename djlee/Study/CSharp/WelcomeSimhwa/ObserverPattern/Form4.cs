using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class Form4 : Form
    {
        Form2 fb2;
        Form3 fb3;
        ISubject sub;
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(ISubject sub, Form2 fb2, Form3 fb3)
        {
            InitializeComponent();
            this.sub = sub;
            this.fb2 = fb2;
            this.fb3 = fb3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sub.unregister(fb2);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            sub.unregister(fb3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sub.register(fb2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sub.register(fb3);
        }
    }
}
