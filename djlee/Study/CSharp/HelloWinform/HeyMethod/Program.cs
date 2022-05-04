using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyMethod
{
    internal class Program
    {
        //method - 함수
        //코드뭉치
        //Main이나 특정 부분에서 다~~~~~ 구현할 수 있지만
        //그러면 코드가 너무 길어지고, 유지보수가 힘들어 진다.
        //그래서 자주쓰이거나 쓰기 어려운 기능은 미리 만들어두고, 간단간단하게 바로바로 호출해서
        //쓰는 거!!!

        //2개의 숫자를 더하되, 둘 중 하나라도 음수면 양수로 바꾼다. 그래서 더한다.

        //메소드 만드는 것 = 선언
        static int AbsAdd(int a, int b) //괄호 안에 있는 int a int b는 매개변수
        {                               //Main에 있는 int a int b와는 전혀 별개
            if (a < 0)
                a *= -1;
            if (b < 0)
                b *= -1;
            return a + b; //반환
        }

        //비밀번호 입력하면 *로 출력되는 기능
        static string getPw() //매개변수가 없음. 파라메터, 아규먼트라는 용어도 있다.
        {
            Console.WriteLine("비밀번호 입력하세요.");
            string pw = Console.ReadLine();
            string result = "";
            for (int i = 0; i < pw.Length; i++)
                result += "*";
            return result;
        }
        static void introduceMySelf()
        {
            Console.WriteLine("이름은?");
            string name = Console.ReadLine();
            Console.WriteLine("MBTI는?");
            string mbti = Console.ReadLine();
            Console.WriteLine("성별은?");
            string gender = Console.ReadLine();
            Console.WriteLine($"{name}의 mbit는 {mbti}이고, 성별은 {gender}이다.");
        }

        //특정한 메시지를 지정한 만큼 출력하고 싶을 때
        static void printMethod(string message, int count)
        {
            if(count<=0)
            {
                Console.WriteLine(count+"! 잘못된 값입니다.");
                return; //밑에꺼 수행 안 하고 메소드를 종료시켜버림
            }

            for(int i = 0; i<count; i++)
                Console.WriteLine(message);
        }

        static void Main(string[] args)
        {

            //new Program().ex(); //객체화

            Console.WriteLine("숫자 입력해봐라");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("숫자 또 입력해라");
            int b = int.Parse(Console.ReadLine());
            if (a < 0)
                a *= -1;
            if (b < 0)
                b *= -1;
            Console.WriteLine(a+b);
            Console.WriteLine(AbsAdd(a,b)); //호출

            string result = getPw(); //getPw가 호출되는 순간 나는 문자열을 입력해야 함
            Console.WriteLine(result);
            Console.WriteLine(getPw()); //getPw가 끝나야 그 결과를 출력할 수 있다.

            int abs = AbsAdd(-100, 50);
            Console.WriteLine("100+50의 절댓값 합은 " + abs  );
            Console.WriteLine("100+50의 절댓값 합은 " + AbsAdd(-50,-100)  );

            //기타등등 잡다부리한 것들은 내가 몰라도 됨
            introduceMySelf();

            printMethod("이동준잘생겼다", 3);
            printMethod("이동준못생겼다", -1); //예외상황
        }
    }
}
