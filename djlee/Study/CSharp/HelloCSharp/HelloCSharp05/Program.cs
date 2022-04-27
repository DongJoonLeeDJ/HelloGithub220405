using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력해보세요.");
            int num = int.Parse(Console.ReadLine());

            if(num%2 == 0)
            {
                Console.WriteLine("짝수");
            }
            Console.WriteLine("num="+num);

            //짝수가 나오면 짝수
            //짝수가 아니면 짝수 아님 이렇게 출력하고 싶다면?
            if(num%2==0)
            {
                Console.WriteLine("짝");
            }
            else
            {
                Console.WriteLine("짝수 아님(=홀수)");
            }

            //3가지 이상이라면?
            //else if-> if가 아닌 다른 조건일 경우
            //코드가 1줄인 경우엔 중괄호 생략 가능함
            if(num>0)
                Console.WriteLine("양수");
            else if(num==0)
                Console.WriteLine(0);
            else
                Console.WriteLine("음수");

            //조건문 안에 조건문이 중첩 가능
            if(num>0)
            {
                if(num%2==0)
                {
                    Console.WriteLine("진짜 짝수임");
                }
                else
                {
                    Console.WriteLine("진짜 홀수");
                }
            }
            else
            {
                if (num == 0)
                {
                    Console.WriteLine("num=0");
                }
                else
                {
                    Console.WriteLine("num은 음수입니다.");
                }
            }

            string result = "";
            if (num > 0)
                result = "num은 0을 넘는다.";
            else
                result = "num은 0을 넘지 않는다.";
            Console.WriteLine(result);

            //이정도 수준의 매우 간단한 조건문은 삼항연산자라는 것으로 한 줄만에 표현 가능함

            result = num > 0 ? "num은양수" : "num은 양수아님";
            Console.WriteLine(result);

            //삼항연산자로 조건 3개이상인 것 표현하기
            //양수, 0, 음수인 경우 표현해보기
            //괄호 이용해서 표현이 가능하긴 한데, 가독성이 떨어짐
            result = num > 0 ? "num은 양수!!!" : (num == 0 ? "num은 zero!!!" : "num은 음수!!!");
            Console.WriteLine(result);
            
            //경우의 수들을 쭉 나열하는 방식.
            //범위를 표현할 땐 부적합하다.(무한대 값이나 3.0~4.0사이의 값에 대한 체크 등)
            switch (num)
            {
                case 1:
                    Console.WriteLine("1입력");
                    break;
                case 100:
                    Console.WriteLine("100입력");
                    break;
                default:
                    if(num<0)
                        Console.WriteLine("음수");
                    else
                        Console.WriteLine("num : " + num);
                    break;
            }

        }
    }
}
