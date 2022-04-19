using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy_ShallowCopy2
{
    internal class Program
    {
        //얕은 복사가 주로 쓰이는 건 함수의 매개변수로써 사용됨
        //함수에서 값이 바뀌어도 main에서도 마찬가지로 값이 바뀌게 함

        static void changeMoney(BankAccount cus, int money)
        {
            cus.money = money;
        }

        //main에 있는 int 변수의 값을 바꿔줌
        //ref : 참조변수
        //일반 변수도 참조변수처럼 쓸 수 있게 해줌.
        static void changeNumber(ref int num, int change)
        {
            num = change;
        }
        static void Main(string[] args)
        {
            int aa = 100;
            int bb = aa;
            bb = 9999;
            Console.WriteLine($"aa={aa}, bb={bb}");

            BankAccount 고객1 = new BankAccount();
            고객1.name = "이동준";
            고객1.money = 5000;
            BankAccount 고객2 = new BankAccount();
            고객2.name = 고객1.name;
            고객2.money = 고객2.money;
            고객2.money = 99999;

            Console.WriteLine($"고객1의 이름 : {고객1.name}, 고객1의 잔액 {고객1.money}");
            Console.WriteLine($"고객2의 이름 : {고객2.name}, 고객2의 잔액 {고객2.money}");

            //얕은 복사
            BankAccount 고객3 = 고객1;//!!!!!!!!!!
            고객3.money = 0;
            Console.WriteLine($"고객1의 이름 : {고객1.name}, 고객1의 잔액 {고객1.money}");
            Console.WriteLine($"고객3의 이름 : {고객3.name}, 고객3의 잔액 {고객3.money}");

            changeMoney(고객2, 9999900); //함수에서 값이 바뀌었는 데, 메인의 변수가 영향을 받는다.
            Console.WriteLine($"고객2의 이름 : {고객2.name}, 고객2의 잔액 {고객2.money}");


            //깊은 복사
            Student ldj = new Student();
            ldj.name = "이동준";
            ldj.score = 100;

            Student ldj_222 = ldj; //동명이인이라서 점수만 다른 경우
            ldj_222.score = 50;

            Console.WriteLine($"ldj의 이름과 점수 {ldj.name}, {ldj.score}");
            Console.WriteLine($"ldj_222의 이름과 점수 {ldj_222.name}, {ldj_222.score}");
            

            //번외 참조변수
            //일반 변수도 ref 붙여서 참조변수화 할 수 있다.
            int mytest = 999;
            changeNumber(ref mytest, 1234);
            Console.WriteLine("mytest="+mytest);
        }
    }
}
