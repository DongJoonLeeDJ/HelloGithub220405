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
    public partial class Form1 : Form, ISubject
    {
        //이 리스트 안에는 IObserver를 구현한 것만 들어갈 수 있다.
        List<IObserver> observers = new List<IObserver>();

        public Form1()
        {
            InitializeComponent();
            textBox1.KeyUp += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    notifyObserver();
                }
            };


            Form2 frm2 = new Form2(this);
            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frm2);
            frm2.Show();
            Form3 frm3 = new Form3(this);
            frm3.TopLevel = false;
            frm3.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm3);
            frm3.Show();

            Form4 frm4 = new Form4(this, frm2, frm3);
            frm4.TopLevel = false;
            panel3.Controls.Add(frm4);
            frm4.FormBorderStyle = FormBorderStyle.None;
            frm4.Show();
        }

        public void notifyObserver()
        {
            foreach (IObserver item in observers)
                item.update(textBox1.Text);
        }

        public void register(IObserver o)
        {
            observers.Add(o);
        }

        public void unregister(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
