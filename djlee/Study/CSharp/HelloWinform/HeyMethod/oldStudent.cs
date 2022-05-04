using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyMethod
{
    public class oldStudent : Student
    {
        public string bType { get; set; }//혈액형 정보 추가

        public void play()
        {
            //Name은 Student에 있는 것이다.
            //하지만 이건 Student를 상속받았으므로 Name은 따로 선언 안해줘도 됨
            Console.WriteLine(Name+"어르신의 치매방지 놀이");
        }

        public override void introduce()
        {
            //base.introduce();
            //어르신은 학번이 따로 존재하지 않는 경우가 많으므로 적지 않는다.
            Console.WriteLine("나이 : " + Age);
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("혈액형 : "+ bType);
        }

    }
}
