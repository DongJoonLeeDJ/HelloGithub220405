using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a += 10; //a=a+10;
            a++; //a=a+1
            a += 1;

            //+, -, / , *, % 모두 다 이와 같이 된다.
            Console.WriteLine("a="+a); //a값이 얼마인지 출력이 됨

            a--;
            a -= 100;
            Console.WriteLine("a="+a);
            //++,--는 값을 하나씩 더하거나 뺄 때 쓴다.
            //참고로 **, //, %% 이런 건 없음

            Console.WriteLine(++a); //더하기부터 하고 출력
            Console.WriteLine(a++); //출력을 하고, 그 변수값은 나중에 변경
            Console.WriteLine(a);
            //var라는 키워드는 자바스크립트의 var랑 다르다.
            //자바스크립트의 var는 처음에 숫자가 들어가더라도
            //그 이후 다양한 값들이 들어갈 수 있다.
            //c#에서는 한 번 값이 정해지면 그 뒤로는 타입은 못 바꿈
            var bb = 123;
            //bb = "aaa";
            var cc = "안녕";
            cc = "잘가";
            //foreach문에서 많이 쓰임

            //var처럼 쓰고 싶다면...?
            //dynamic이라는 걸 쓰면 된다.
            dynamic abc = 123;
            abc = "일이삼";

            //입력
            Console.WriteLine("이름이 뭐에요?");
            string name = Console.ReadLine();
            Console.WriteLine("내 이름은 " + name+"입니다.");

            Console.WriteLine("나이는 몇살인가요?");
            int age = int.Parse(Console.ReadLine());

            //int.Parse의 역할
            int mybirth = int.Parse("1989"); //숫자로 바꿔줌

            Console.WriteLine("내 나이와 태어난 연도로 봤을 때");
            Console.WriteLine("올해는 " + (age+mybirth-1)+"이다.");
            //문자열에선 빼기가 안 되기도 하고 된다 하더라도 결과가
            //이상했을 것이다.
            //Console.WriteLine("올해는 " + age+mybirth-1+"이다.");

            //연산자간의 우선순위 때문에 값이 이상할 때 
            //그리고 쌍따옴표 뒤에 숫자들을 더하고 싶을 때 
            //괄호를 이용하면 된다.(괄호로 묶기)
            //1+2*3 => 7
            //(1+2)*3 -> 6

            //값을 문자열로 바꾸는 방법 3가지
            //ToString 혹은 ""을 더한다.
            string myPi = 3.14.ToString();
            string myPi2 = "" + 3.14;
            string myPi3 = 3.14+"";
            Console.WriteLine(myPi+myPi2+myPi3);

        }
    }
}
