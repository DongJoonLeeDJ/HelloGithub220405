using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXppt02
{
    internal class Program
    {
        //enum
        //열거형
        enum Fruits
        {
            포도,바나나=2,토마토,두리안=100
        }
        static void Main(string[] args)
        {
            string[] 과일들 = new string[] { "포도", "???", "바나나", "토마토" };

            Console.WriteLine(과일들[0]);
            Console.WriteLine(과일들[(int)Fruits.포도]); 
            Console.WriteLine(과일들[(int)Fruits.바나나]);

            Robot r = new FactoryRobot();//다형성
            FactoryRobot fr = new FactoryRobot();
            // Robot r2 = new Robot();
            r.eStop();
            fr.eStop();

        }
    }
}
