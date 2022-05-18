using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeSimhwa02
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "ID:" + Id + ",이름:" + Name + ",나이:" + Age;
        }
    }
}
