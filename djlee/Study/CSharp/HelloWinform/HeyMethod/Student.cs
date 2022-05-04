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

        //private int grade;
        //public int Grade { get { return grade; } set { grade = value; } } 
        //public int Grade { get =>  grade;  set => grade = value;  } 

        public void setInfo(string Name, int Age, string Hakbeon)
        {
            //this는 인스턴스 변수 즉 멤버변수를 가리킴
            //this 없는 건 매개변수를 가리킴
            this.Name = Name;
            this.Age = Age;
            this.Hakbeon = Hakbeon;
        }
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
