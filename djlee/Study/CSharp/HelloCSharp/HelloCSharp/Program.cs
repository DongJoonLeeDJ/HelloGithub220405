using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class MyClass
    {
        public static int age { get; set; }
    }

    class Program
    {
        public static int age { get; set; }
    }
}

namespace HelloCSharp
{
    internal class Program
    {
        public static int age { get; set; }
        static void Main(string[] args)
        {

            age = 10;
            MyNamespace.MyClass.age = 100;
            MyNamespace.Program.age = 100;
            Console.WriteLine("안녕하세요");

            Console.Write("Write");
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine"); //ctrl d 하면 줄복사 붙여넣기
            Console.Write("Write");
            Console.WriteLine("Write");
        }
    }
}
