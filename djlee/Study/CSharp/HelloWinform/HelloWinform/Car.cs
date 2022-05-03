using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWinform
{
    public class Car
    {
        //인스턴스 변수
        //인스턴스 별로 별도의 값을 갖는 것
        //자동차가 3개가 있다면 new Car(), new Car(), new Car()
        //이런식으로 3개가 만들어지고 각각 Name, Description, Price가 다름
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        //클래스 변수
        //Car.Count, Car.companyName 이런식으로 사용이 되고
        //모든 Car 클래스가 공통된 값을 가짐
        //공용으로 쓰는 값들
        //자동차의 총 개수, 자동차 관리하는 회사와 같이 모든 자동차가 
        //공통적으로 갖는 값
        public static int Count { get; set; }
        public static string companyName { get; set; }

        //생성자
        //자동차의 전체 개수 : Count
        //자동차별로 전체 개수 값이 다르진 않다.
        //그래서 new Car()할 때, 자동차의 전체 개수가 하나씩 늘어난다.
        public Car()
        {
            Console.WriteLine("자동차 만듭니다. 부릉부릉");
            Count++;
        }
    }
}
