using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyMethod
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hakbeon { get; set; }

        public void introduce()
        {
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("나이 : " + Age);
            Console.WriteLine("학번 : " + Hakbeon);
        }
        public void Stduy()
        {
            Console.WriteLine("열심히 공부를 합니다. 아뵤~");
        }
    }
}
