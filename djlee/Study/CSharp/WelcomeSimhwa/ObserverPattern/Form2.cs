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
    public partial class Form2 : Form, IObserver
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(ISubject sub)
        {
            InitializeComponent();
            sub.register(this);//this:form2, IObserver 구현함
        }

        public void update(string value)
        {
            textBox1.Text = value;
        }
    }
}
