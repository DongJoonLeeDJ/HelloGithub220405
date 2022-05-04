using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyMethod
{
    public class youngStudent : Student
    {
        public double kg { get; set; }
        public double cm { get; set; }

        public void sleep()
        {
            Console.WriteLine(Hakbeon+"번 어린이는 잠을 잡니다.");
        }

        public override void introduce()
        {
            //base -> 조상 클래스
            base.introduce();//이름 나이 번호 출력
            //추가적인 정보를 더 출력.
            //Student의 introduce랑 달라!
            Console.WriteLine("kg : " + kg);
            Console.WriteLine("cm : " + cm);
        }
    }
}
