using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (괄호조건이 true면 계속 수행)
            while (true) //근데 여기에 true를 뒀다는 건 무한반복문
            {
                Console.WriteLine("숫자 입력해보세요.");
                int num = int.Parse(Console.ReadLine());
                if(num<0)
                {
                    Console.WriteLine("음수 입력했으므로 종료");
                    break;
                }
                Console.WriteLine("num="+num);
            }
            //do while문은 while 괄호 안에 조건이 아무리 거짓이라도 무조건 한 번은 수행함
            do
            {
                Console.WriteLine("한 번은 무조건 실행. 경우에 따라선 무한대로 실행함");
            } while (/*10!=10*/ false);

            //1부터 10까지의 합을 구한다.
            int mynum = 0;
            int sum = 0;
            while (mynum < 10)
            {
                mynum++;
                sum += mynum; // sum = sum+mynum;
            }
            Console.WriteLine("sum="+sum);


            //1부터 5까지의 곱 구하기
            //1x2x3x4x5 = 120
            int result = 1;
            for(int i = 0; i<5; i++)
            {
                result *= (i + 1); //result = result*(i+1)
            }
            Console.WriteLine("result="+result);
            
        }
    }
}
