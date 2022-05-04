using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyMethod
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hakbeon { get; set; }

        //private int grade;
        //public int Grade { get { return grade; } set { grade = value; } } 
        //public int Grade { get =>  grade;  set => grade = value;  } 

        //생성자
        //인스턴스를 만듦과 동시에 바로 멤버변수들의 값들 추가해줄 수 있다.
        public Student(string Name, int Age, string Hakbeon)
        {
            this.Name = Name;
            this.Age = Age;
            this.Hakbeon = Hakbeon;
        }
        //생성자는 이름이 겹치더라도 매개변수의 개수나 타입이 다르면 얼마든지 여러 개 쓸 수 있다.
        //근데 이 법칙은 메소드(인스턴스메소드든 클래스메소드든 상관없이) 에서도 적용이 됩니다.
        //이렇게 이름만 겹치고 매개변수가 다른 걸 "오버로딩"이라고 한다!!!
        

        //class 만들 때 생성자를 안 만들면... 아래와 같이 비어있는 생성자가 
        //자동으로 하나 만들어짐(암묵적으로)
        //근데 매개변수가 있는 생성자 혹은 매개변수는 없는 데 뭔가 기능을 하는 생성자를 하나
        //만들 게 되면 기존의 비어있는 생성자는 삭제가 된다.
        public Student()
        {

        }

        public void setInfo(string Name, int Age, string Hakbeon)
        {
            //this는 인스턴스 변수 즉 멤버변수를 가리킴
            //this 없는 건 매개변수를 가리킴
            this.Name = Name;
            this.Age = Age;
            this.Hakbeon = Hakbeon;
        }
        //인스턴스 메소드
        //학생"별로 각각 다르게" 하는 기능
        public void introduce()
        {
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("나이 : " + Age);
            Console.WriteLine("학번 : " + Hakbeon);
        }
        //클래스 메소드
        //공통 기능
        //Student 클래스 자체의 기능
        public static void Study() //학생들이 전부 다 "공통적으로" 하는 기능
        {
            Console.WriteLine("열심히 공부를 합니다. 아뵤~");
        }
        public static void Study(int hour)
        {
            Console.WriteLine(hour+"시간 공부를 합니다.");
        }
    }
}
