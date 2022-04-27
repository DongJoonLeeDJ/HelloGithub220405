using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inch 입력받으세요.");
            int inch = int.Parse(Console.ReadLine());
            Console.WriteLine(inch+"inch="+(inch*2.54)+"cm");

            Console.WriteLine("kg 입력받으세요.");
            int kg = int.Parse(Console.ReadLine());
            Console.WriteLine($"{kg}kg = {kg*2.20462262}pound");

            const double PI = 3.14; //const - 상수
            //public const double PI = 3.1415926535897931;
            //그냥 3.14를 써도 되지만 가독성을 위해서 PI를 썼다
            //그리고 지금은 원주율을 3.14라고 하지만
            //프로그램에 따라서 3.1415 등의 정밀한 값을 쓸 수 있다.
            //그 때 선언부에서 바꾸면 된다.
            //단, 이건 상수라서 선언 이후엔 못 바꿈
            //PI = 3.1415;
            
            Console.WriteLine("원의 반지름은?");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"원의 둘레 : {2*PI*r}");
            //{0},{1},{2}...이렇게 늘어나고 그에 따라서 코드가 많이 길어짐
            //그리고 어떤 게 0번째고, 1번째인지 구분도 힘듦
            Console.WriteLine(string.Format("원의 넓이 : {0}", r*r*PI));

            Console.WriteLine("첫번째 숫자 입력해보세요.");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 숫자 입력해보세요.");
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine(one *  (two%10)); //첫번째 숫자 x 두번째 숫자의 일의 자리
            Console.WriteLine(one *  ((two/10)%10) ); //첫번째 숫자 x 두번째 숫자의 십의 자리
            Console.WriteLine(one * (two/100)); //첫번째 숫자 x 두번째 숫자의 백의 자리
            Console.WriteLine(one*two); //첫번째 숫자 x 두번째 숫자

            string twoStr = two + "";
            Console.WriteLine(one * (twoStr[2]-'0'));//아스키코드표상에서 '0'은 48이다.
            Console.WriteLine(one * (Char.GetNumericValue(twoStr[1])));
            Console.WriteLine(one * (Char.GetNumericValue(twoStr[0])));
            Console.WriteLine(one * int.Parse(twoStr)); //그냥 two 써도 됨...

        }
    }
}
