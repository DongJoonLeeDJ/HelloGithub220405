using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            for (int i = 1; i <= 100; i++)
                sum += i;
            Console.WriteLine(sum);

            //한글전부출력
            //유니코드표상에서는 가부터 시작해서 힣까지
            for(char c = '가'; c<='힣'; c++)
                Console.Write(c);

            //가부터 힣까지 무한대로 출력하는 방법
            for(char c = '가'; c<='힣'; c++)
            {
                Console.Write(c);
                //if (c == '힣') //주석 해제하면 무한...
                //    c = '가';
            }
            
            for(char c = 'ぁ'; c<= 'ゔ'; c++)
                Console.Write(c);

            //break라는 걸 배웠다. switch, for, do while, while에서 모두 쓰임
            //break를 만나면 바로 중단됨.

            //continue
            //중단시키는 게 아니고 다음 단계로 바로 점프를 뛰어버림

            //1부터 10까지의 숫자를 출력하는 데, 짝수만 출력하고 싶다.
            //이 때 홀수를 만나면 출력하지 않고 바로 다음단계로 가야 한다.

            for(int i = 1; i <=10; i++)
            {
                if (i % 2 != 0)
                    continue; //밑에 프린트하는 코드를 수행하지 않고 바로 i++로 건너뛰어 버림

                Console.WriteLine(i);
            }

        }
    }
}
