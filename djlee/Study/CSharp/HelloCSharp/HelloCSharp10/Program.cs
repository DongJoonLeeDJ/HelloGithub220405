using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //break, continue
            //goto

            //goto키워드 : 권장하지 않음
            //하지만 가끔 쓰는 분들이 있음

            while(true)
            {
                Console.WriteLine("숫자 입력");
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    goto TempPos;

                if (num < 0)
                    break;

            }
            Console.WriteLine("while문 끝남");
        TempPos:
            Console.WriteLine("goto문에 따라 이리로 바로 이동될 수도 있음");

            //자바스크립트의 for of와 같은 것이 있다.
            //배열에 있는 값들을 모두 출력한다거나 모두 이용할 경우
            //for문으로 쓸 필요 없다.
            //foreach라는 걸 이용할 수도 있다.

            //배열에 있는 값들을 모두 출력하는 코드를 만들어보자.

            int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            for(int i = 0; i<numbers.Length; i++)
                Console.WriteLine(numbers[i]);

            //이 item이 numbers 배열 안에 있는 값들 하나하나를 의미
            //var는 타입이 정해져 있지는 않지만 한 번 정해지면 그 타입으로 굳어짐
            //여기선 numbers가 int 배열이므로 item은 int타입이다.
            foreach (var item in numbers) //numbers 배열의 크기에 따라서 반복횟수가 정해짐. 여기선 5번
            {
                Console.WriteLine(item);
            }

            //Split, Join
            //Split - 자르다. 문자열을 구분자에 따라 잘라서 배열
            //Join - 배열을 한 덩어리로 만듦

            string mylist = "이동준,문찬호,한준범,이재형";
            string[] f4 = mylist.Split(',');
            foreach (var item in f4)
            {
                Console.WriteLine(item);
            }
            string mynamelist = string.Join("@", f4); //구분자를 @로 해서 합침
            Console.WriteLine(mynamelist);//이동준@문찬호@한준범@이재형

        }
    }
}
