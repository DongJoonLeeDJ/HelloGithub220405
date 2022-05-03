using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinform
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //사용자 정의 자료형을 이용한 변수 선언
            Car c = new Car();
            c.Name = "마티즈";
            c.Description = "아빠한테 받은 차";
            c.Price = 0;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form2());
            Application.Run(new Form1());
        }
    }
}
