using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyMethod
{
    public class Circle
    {
        //public, private 그리고 protected라는 것이 있다.
        //우린 계속 public만 써왔다.
        //이것들을 접근 제한자라고 부름
        //public이 붙으면 아무데서나 다 접근이 가능함

        //private이 붙어간 아무것도 안 적히면
        //이 클래스 내부에서만 접근이 되고, 밖에서... 즉 다른 클래스에선 접근 안 됨

        public static double PI;

        //반지름 값을 정의하는 다양한 방법
        //public int r; //나중에 datagridview나 dataSource파트에서
        //클래스 있는 속성 읽어야 되야 하는 데, {get;set;}  안 붙어있으면
        //안 읽어와짐...

        //아무것도 안 적으면 기본 값은 private
        //int radius;
        private int radius;
        //이거 2개는 똑같은 코드
        //public int myR { get => radius; set => radius = value; }
        public int myR { get { return radius; } set { radius = value; } }

        public int myRadius {get;set;} //제일 많이 쓰임


        //java 스타일
        private int r;
        public int getR()
        {
            return r;
        }
        public void setR(int r)
        {
            if (r <= 0)
                r = 0;
            this.r = r;
        }

    }
}
