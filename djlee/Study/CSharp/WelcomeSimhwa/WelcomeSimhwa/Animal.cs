using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeSimhwa
{
    public abstract class Animal
    {
        public string masterName { get; set; }
        public int age { get; set; }

        public abstract void charming();
        public abstract void attack();

        //protected
        //상속한 것들만 쓸 수 있는 것
        protected void cry()
        {
            System.Windows.Forms.MessageBox.Show("동물 울음소리를 냅니다.");
        }
    }
}
