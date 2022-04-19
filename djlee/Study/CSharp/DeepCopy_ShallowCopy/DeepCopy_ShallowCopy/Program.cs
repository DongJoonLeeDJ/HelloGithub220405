using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy_ShallowCopy
{
    internal class Program
    {
        static void 잔액변경하기(BankAccount 고객)
        {
            고객.잔액 = 909090;
        }

        static void 잔액변경하기(BankAccount2 고객)
        {
            고객.잔액 = 123123;
        }

        
        static void Main(string[] args)
        {
            //일반 적인 복사

            int a = 100;
            int b = a;
            b = 1000;
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b); //b가 바뀐다고 a가 바뀌진 않는다.

            BankAccount 박나은 = new BankAccount();
            박나은.고객명 = "박나은";
            박나은.잔액 = 100000;

            BankAccount 이동준 = 박나은; //잔액이 똑같아서 복사...(얕은 복사)
            이동준.잔액 = 0;

            Console.WriteLine(박나은.잔액);
            Console.WriteLine(이동준.잔액);

            잔액변경하기(박나은);
            Console.WriteLine(박나은.잔액);


            //깊은 복사 = 얕은 복사의 반대
            //값만 철저하게 복사함

            BankAccount2 강동호 = new BankAccount2();
            강동호.이름 = "강동호";
            강동호.잔액 = 1000;

            BankAccount2 강호동 = 강동호;
            강호동.잔액 = 999999;

            Console.WriteLine(강동호.잔액);
            Console.WriteLine(강호동.잔액);

            잔액변경하기(강호동);
            Console.WriteLine(강호동.잔액); 

            
        }
    }
}
