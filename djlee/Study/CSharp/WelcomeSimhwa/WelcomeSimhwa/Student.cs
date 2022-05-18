using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeSimhwa
{
    //<Student> 생략시 CompareTo의 매개변수가 Object 타입이다.

    public class Student :IComparable<Student>
    {
        public int score { get; set; }
        public string name { get; set; }
        public int num { get; set; }

        public int CompareTo(Student other)
        {
            return score.CompareTo(other.score);
        }

        public override string ToString()
        {
            return "이름:" + name + ",번호:" + num + ",점수:" + score;
        }
    }
}
