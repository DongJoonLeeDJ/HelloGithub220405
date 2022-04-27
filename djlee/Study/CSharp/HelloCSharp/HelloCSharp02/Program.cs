using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //정수
            Console.WriteLine("정수");
            Console.WriteLine(5+2); 
            Console.WriteLine(5-2);
            Console.WriteLine(5*2); //shift + 8  *^^* 하이루
            Console.WriteLine(5/2); //정수끼리 나누면 결과 정수. 소수점 버림
            Console.WriteLine(5%2); //숫자를 나눴을 때의 나머지 값
            Console.WriteLine(1%2); //값 : 1, 1을 2으로 나누면 몫 : 0, 나머지 1

            //실수
            Console.WriteLine("실수");
            Console.WriteLine(5.0/2);
            Console.WriteLine(2.0/5);
            Console.WriteLine(5.0/2.0);

            //문자 -> 1글자
            //숫자로 변환이 됨
            //숫자는 문자로 변환도 됨
            Console.WriteLine("문자");
            Console.WriteLine('a');
            Console.WriteLine((int)'a');//97
            Console.WriteLine((char)97);
            Console.WriteLine((int)'가');
            Console.WriteLine((char)12363);
            Console.WriteLine((int)'警');

            //문자열
            //쌍따옴표 안에 있음. 1글자 이상
            Console.WriteLine("문자열");
            Console.WriteLine("안녕");
            Console.WriteLine("문자열은 +랑 같이 쓰인다.");
            Console.WriteLine("안녕"+"하세요");//안녕하세요
            Console.WriteLine(10+20+"30");//문자열을 만나니 "3030"이 됨
            Console.WriteLine("10"+20+30);//문자열을 만나고 나면 그 뒷부분은 다 문자열 결과:102030

            //만약에 쌍따옴표 자체를 출력하고 싶다면?
            //\(역슬래시라고도 하고, 돈표시라고도 함)
            //글자체에 따라서 다르게 출력됨
            //escape(이스케이프)문자
            Console.WriteLine("내 이름은 \"이동준\"입니다.");
            //escape 문자 자체를 출력하고 싶다면 \\ 이렇게 적으면 됨
            Console.WriteLine("\\는 이스케이프문자입니다.");
            //이스케이프 문자에 한해서만, \\ 이렇게 쓰는 거 말고 @를 이용하는 방법도 있다.
            Console.WriteLine(@"\는 이스케이프이다.");
            Console.WriteLine("안녕하세요"[0]);//문자열 선택자
            Console.WriteLine("안녕하세요"[4]);//문자열 선택자

            //문자열 말고 문자는 덧셈 연산하면 숫자가 출력됨
            Console.WriteLine("A"+"A");//AA
            Console.WriteLine('A'+'A');//130 (65+65)
            Console.WriteLine("A"+"A"+'A'+'A');//AAAA

            Console.WriteLine("불(bool)");
            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.WriteLine(10==10); //true 같다
            Console.WriteLine(10>10);//false 크다
            Console.WriteLine(10!=10);//false 다르다
            Console.WriteLine(10>=10);//true 크거나 같다

            //AND OR NOT XOR
            //XOR : 모든 식이 다 거짓이거나 다 참이면 그건 거짓
            //하나라도 다른 게 섞여 있으면 그건 참
            //기호는 ^

            Console.WriteLine(10==10 && 11==11); //두 조건이 모두 참이어야지만 True
            Console.WriteLine(10!=10 && 11==11); //하나라도 다르면 false

            //OR
            Console.WriteLine(10!=10 || 11==11); //하나라도 만족하면 True

            //NOT
            Console.WriteLine(!(10!=10)  );//반대



        }
    }
}
