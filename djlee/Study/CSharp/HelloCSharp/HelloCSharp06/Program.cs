using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp06
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //내가 태어난 연도를 입력하고 그에 따른 띠를 출력
            Console.WriteLine("몇년도에 태어나셨나요?");
            int thee = int.Parse(Console.ReadLine());

            //띠는 12개가 무한반복함
            //쥐 소 호랑이 토끼 / 용 뱀 말 양 /원숭이 닭 개 돼지
            //1989%12 => 9 => 뱀
            //서기 1년 -> 닭띠
            //12로 나눴을 때 0인 경우 : 원숭이

            switch (thee%12)
            {
                case 0:
                    Console.WriteLine("원숭이");
                    break;
                case 1:
                    Console.WriteLine("닭");
                    break;
                case 2:
                    Console.WriteLine("개");
                    break;
                case 3:
                    Console.WriteLine("돼지");
                    break;
                case 4:
                    Console.WriteLine("쥐");
                    break;
                case 5:
                    Console.WriteLine("소");
                    break;
                case 6:
                    Console.WriteLine("호랑이");
                    break;
                case 7:
                    Console.WriteLine("토끼");
                    break;
                case 8:
                    Console.WriteLine("용");
                    break;
                case 9:
                    Console.WriteLine("뱀");
                    break;
                case 10:
                    Console.WriteLine("말");
                    break;
                case 11:
                    Console.WriteLine("양");
                    break;
                default:
                    Console.WriteLine(thee); //혹시 몰라서 넣어둠... 이리로 올 일 없음
                    break;
            }

            //계절출력
            //if문을 쓸 수도 있고, switch를 쓸 수도 있다.
            Console.WriteLine("지금은 몇월인가요?");
            int month = int.Parse(Console.ReadLine());
            if(month==12 || month == 1|| month ==2)
            {
                Console.WriteLine("겨울");
            }
            else if(month >= 3 && month <=5)
                Console.WriteLine("봄");
            else if(month >= 6 && month <=8)
                Console.WriteLine("여름");
            else if(month >= 9 && month <=11)
                Console.WriteLine("가을");
            else
                Console.WriteLine("잘못된 값입니다.");

            switch (month)
            {
                //12나 1이나 2 셋중에 하나가 나오면 이 메시지 출력하고 switch문을 종료
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울이에요");
                    break;
                case 3:
                    //Console.WriteLine("3월이에요");
                    //break ;
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                default:
                    Console.WriteLine("그건 잘못된 값입니다.");
                    break;
            }

            Console.WriteLine("사람의 나이를 입력하고 그에 따른 결과를 출력해보기");

            //switch문과 if문 둘 다 가능한데
            //100% switch문으로는 불가능함(0미만 150이상 표현이 불가능)
            //어쩌면 가능할 수도 있긴 하겠다.... 

            Console.WriteLine("몇 살인가요?");
            int age = int.Parse(Console.ReadLine());

            //-1/10 -> 0
            //Console.WriteLine(1.0/-10); //분모부분이 음수여야 결과가 음수로 나옴
            //근데 애초에... 음수를 나눠서 결과가 음수라는 게 말이 안 됨...

            //결론 : switch만으론 음수에 대한 예외처리 할 수 없음. (어떻게든 간접적으론 된다)
            switch (age/10)
            {
                case 0: //0살,1살,~~9살까지는 10으로 나누면 결과가 0
                case 1: //10부터 19살까진 10으로 나누면 결과가 1
                    Console.WriteLine("젊은이");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("젊은이");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("중년");
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                    Console.WriteLine("노년");
                    break;
                case 15://150이상에 대해선 표현이 가능
                default:
                    //if...
                    Console.WriteLine("타노스");
                    break;
            }

            if(age<0 || age>=150)
                Console.WriteLine("타노스!!!");
            else
            {
                if(age>=0 && age<=19)
                    Console.WriteLine("아이!");
                else if(age<40)
                    Console.WriteLine("젊은이!");
                else if(age<60)
                    Console.WriteLine("중년!");
                else//60부터 149까진 여기에 다 걸림
                    Console.WriteLine("노년");
            }




        }
    }
}
