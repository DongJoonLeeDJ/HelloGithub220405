using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("배열");

            //하나의 변수는 하나의 값만 가진다.
            int num = 100;

            //배열을 쓰게 되면 여러 개의 값을 관리할 수 있게 된다.
            //예를 들어서 10명의 점수를 관리한다면
            //변수를 10개 써야 하는 데, 변수 10명분의 메모리를
            //할당하고, 그 할당된 메모리를 쓸 수 있는 변수를 만든다.

            int[] numbers = new int[10];

            int[] numbers2 = new int[] { 100, 50, 70, 40, 80 };


            //가장 첫번째 [0]
            //가장 끝번째 [길이-1]
            numbers[0] = 100;
            numbers[9] = 1000;

            Console.WriteLine(numbers2[3]); //네번째꺼 출력

            //3칸짜리 문자열 배열 만들기도 가능함
            string[] names = new string[] { "이동준", "문찬호", "한준범" };

            //즉석 문제
            //이 배열을 이용해서 내가 무슨 띠인지 출력하기
            //여기서 입력값은 내 나이(한국식)
            Console.WriteLine(DateTime.Now.Year); //DateTime.Now.Year =  올해

            //띠값을 저장하는 배열이 있어야 함
            string[] thees = new string[] {
                "원숭이", "닭","개","돼지",
                "쥐","소","호랑이","토끼" ,
                "용","뱀","말","양"
            }; 
            Console.WriteLine("나이를 입력해주세요.");
            int age = int.Parse(Console.ReadLine());
            age = DateTime.Now.Year - age + 1; //한국식나이
            Console.WriteLine(thees[age%12]);
        }
    }
}
