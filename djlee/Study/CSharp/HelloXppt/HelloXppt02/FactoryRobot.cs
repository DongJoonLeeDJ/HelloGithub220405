using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXppt02
{
    public class FactoryRobot : Robot
    {
        //FactoryRobot이 Robot을 상속한다면 
        //반드시 eStop을 구현해야 한다.
        //eStop을 반드시 오버라이딩 함
        //단, 추상클래스 아니면 조상클래스의 메소드를 꼭 오버라이딩할 필요x

        public override void eStop()
        {
            Console.WriteLine("윙윙 울면서 꺼진다.");
            //throw new NotImplementedException();
        }
    }
}
