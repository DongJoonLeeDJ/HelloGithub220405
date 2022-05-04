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
        /// <summary>
        /// 매개변수 2개 반환 값 없으나 상황에 따라서 종료시킴
        /// </summary>
        /// <param name="message">출력할 메세지</param>
        /// <param name="count">메세지 출력 횟수</param>
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

        /// <summary>
        /// 참조변수 개념(깊은 복사와 얕은 복사)
        /// 참조 변수 : 값을 저장하는 게 아니고 메모리 영역을 가리키는 변수
        /// 혹은 특정 변수를 가리키는 변수.
        /// </summary>
        /// <param name="numbers"></param>
        public static void change(int[] numbers)
        {
            for(int i = 0; i<numbers.Length; i++)
                numbers[i] = 0;
        }
        public static void change(int num)
        {
            num = 0;
        }
        public static void change(ref int num) //얕은 복사라기 보단... 해당 변수 가리키는 참조자를 
        {                               //활용...(얕은 복사라고 볼 수도 있긴 하다)
            num = 0;
        }
        public static void change(Car car)
        {
            car.Price = 0;
            car.Name = "0";
        }

        public static void change(Student student)
        {
            student.Name = "00";
            student.Hakbeon = "0000";
            student.Age = -1;
        } 

        static void Main(string[] args)
        {
            if(false)
            {
                /// 주석도 이런 거 있긴 있다
                /// 엔터치면 막 생기죠 ㅋㅋㅋ
                /// 메소드 부가 설명 이걸로 많이 합니다 ㅎㅎㅎ
                /// 

                #region Main에서의 메소드 호출 연습



                //new Program().ex(); //객체화

                Console.WriteLine("숫자 입력해봐라");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("숫자 또 입력해라");
                int b = int.Parse(Console.ReadLine());
                if (a < 0)
                    a *= -1;
                if (b < 0)
                    b *= -1;
                Console.WriteLine(a + b);
                Console.WriteLine(AbsAdd(a, b)); //호출

                string result = getPw(); //getPw가 호출되는 순간 나는 문자열을 입력해야 함
                Console.WriteLine(result);
                Console.WriteLine(getPw()); //getPw가 끝나야 그 결과를 출력할 수 있다.

                int abs = AbsAdd(-100, 50);
                Console.WriteLine("100+50의 절댓값 합은 " + abs);
                Console.WriteLine("100+50의 절댓값 합은 " + AbsAdd(-50, -100));

                //기타등등 잡다부리한 것들은 내가 몰라도 됨
                introduceMySelf();

                printMethod("이동준잘생겼다", 3);
                printMethod("이동준못생겼다", -1); //예외상황
                #endregion

            }


            if(false)
            {
            #region 클래스,인스턴스메소드및클래스메소드

            
            Student s = new Student();
            s.setInfo("이동준", 34, "09");
            Student s2 = new Student() { Age=20, Hakbeon="22", Name="정병주"};
            Student s3 = new Student();
            s3.Name = "문찬호";
            s3.Age = 34;
            s3.Hakbeon = "08";

            s.introduce(); //인스턴스 메소드 호출
            s2.introduce();
            s3.introduce();

            Student.Study(); //클래스 메소드 호출
            //s.Study();
            //s2.Study();
            //s3.Study();

            Student s4 = new Student("김영환", 30, "17");//학생을 선언하자마자 정보를 아는 경우
            Student s5 = new Student();//지금은 모르고 나중에 알 수 있는 경우
            s5.setInfo("한준범", 25, "21");

            Student.Study(10);
            #endregion

            }

            //class랑 struct 차이
            //깊은 복사 얕은 복사

            //깊은 복사 : 객체끼리 복사할 때 값까지 다 복사되는 것
            //얕은 복사 : 주소만 복사됨. 그래서 복사 후 복사본의 값을 바꿀 경우엔 반드시 깊은 복사
            //써야 한다. 그래야 원본이 영향을 받지 않는다.

            //결론
            //class는 얕은 복사를 쓰고, 깊은 복사하려면 별도의 조치 혹은 수동으로 하나하나 다 복사
            //struct는 int나 char처럼 쉽게 복사가 됨

            int aa = 100;
            int bb = aa;
            bb++; //bb의 값이 증가한다고 해서 aa의 값이 바뀌진 않음. 
            Console.WriteLine("aa="+aa);
            Console.WriteLine("bb="+bb);

            Student ss1 = new Student("이동준2", 34, "1234");
            Student ss2 = ss1; //얕은 복사
            ss2.Age = 20;
            ss2.Hakbeon = "22";

            Console.WriteLine(ss1.Name+ss1.Age+ss1.Hakbeon); //얕은 복사의 문제점!!!
            Console.WriteLine(ss2.Name+ss2.Age+ss2.Hakbeon);

            Car c1 = new Car();
            c1.Price = 500;
            c1.Name = "5시리즈(k5)";

            Car c2 = c1; //깊은 복사가 됨. 구조체니까...
            c2.Name = "bmw5";
            Console.WriteLine(c1.Name+c1.Price);
            Console.WriteLine(c2.Name+c2.Price);

            Console.WriteLine("--------------------------");
            //메소드와 참조변수
            int number = 111;
            change(number); //number의 값인 111을 복사해온 num은 0이 되지만, main의 number와는 상관없는 일
            Console.WriteLine(number);

            //배열도 클래스처럼 얕은 복사를 쓴다!
            int[] numbers = new int[] { 10, 20, 30 };
            change(numbers); //main에는 10,20,30인데... 이 메소드 거치고 나서
            foreach (var item in numbers) //안의 값들이 모두 0으로 바뀜
            {
                Console.WriteLine(item);
            }

            Car c = new Car();
            c.Name = "이동준";
            c.Price = 5000;
            change(c); //메소드에서 무슨 짓을 해도 영향을 받지 않는다!!!
            Console.WriteLine("이름:"+c.Name+" 가격:"+c.Price);

            //ref는 number의 위치(혹은 number를 가리키는 변수)
            //참조자라고 함
            change(ref number);
            Console.WriteLine("number="+number);

            //class도 메소드에서 값 변하면 main에서도 변함
            Student s_test = new Student();
            s_test.Name = "이동준선생님";
            s_test.Age = 13;
            s_test.Hakbeon = "09";
            change(s_test);
            Console.WriteLine(s_test.Name+":"+s_test.Age);

            Console.WriteLine("--------------------------");
        }
    }
}
