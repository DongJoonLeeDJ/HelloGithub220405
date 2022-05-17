using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXppt
{
    internal class Program
    {
        void printHello()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("안녕");
        }
        int Multi(int x, int y)
        {
            return x * y;
        }
        class Test
        {
            public int Multi(int x, int y)
            {
                return x * y;
            }
            public void mytest()
            {
                mytest();
            }
        }

        Dictionary<int, long> memo = new Dictionary<int, long>();
        long Fibonacci(int i)
        {
            if(i<0) { return 0; }
            if (i == 1) { return 1; }
            if(memo.ContainsKey(i))
            {
                return memo[i];
            }
            else
            {
                long value = Fibonacci(i - 2) + Fibonacci(i - 1);
                memo[i] = value;
                return value;
            }
        }
        //딕셔너리 없는 재귀함수
        long Fibonacci(long i)
        {
            if (i < 0)
                return 0;
            if (i == 1)
                return 1;
            if (i == 2)
                return 1;
            return Fibonacci(i - 2) + Fibonacci(i - 1);
        }

        static void Main(string[] args)
        {
            //new Test().mytest();
            int a = new Test().Multi(2, 3);
            int b = new Program().Multi(2, 3);
            Console.WriteLine(a);
            Console.WriteLine(b);
            new Program().printHello();
            Program p = new Program();
            p.printHello();

            // Program.Main(null);
            // Main(null);

            //Console.WriteLine("재귀함수(딕셔너리없는거)");

            //Console.WriteLine(p.Fibonacci(50L)); //뒤에 L 붙으면 숫자를 long타입으로 변경한 거임

            Console.WriteLine("재귀함수(딕셔너리쓴거)");
            Console.WriteLine(p.Fibonacci(50));

        }
    }
}
