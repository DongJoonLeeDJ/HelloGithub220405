using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinform03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student() { Name="이동준", Grade=1});
            Student s = new Student();
            s.Name = "박나은";
            s.Grade = 2;
            students.Add(s);
            students.Add(new Student() { Name = "강동호", Grade = 3 });
            students.Add(new Student());
            students[3].Name = "문찬호";
            students[3].Grade = 4;

            students.Add(new Student() { Name = "이운복", Grade = 1 });
            students.Add(new Student() { Name = "이재형", Grade = 2 });

            //list에 있는 내용을 label에 넣을 것이며
            //label은 코드상으로 만들 것이다.
            for(int i = 0; i<students.Count; i++)
            {
                Label label = new Label();
                Controls.Add(label);
                label.Text = $"{students[i].Grade}학년 {students[i].Name} 학생";
                label.AutoSize = true;
                label.Location = new Point(13, 13 + 26 * i);
                //Controls.Add(label);
            }
           
            //1학년만 남기려고 함
            //뭔가 데이터를 순차적으로 제거해야 가야 할 때는 역for문을 써줘야 한다.
            //일반 for문을 쓰면 데이터를 제거한 것 때문에 indexBound에러가 남
            //원래 5칸짜리라서 for문이 5번 돌아야 하는 데, 중간에 데이터를 하나라도 지우면
            //마지막 5번째에서는 무조건 인덱스 bound 에러가 걸림
            //하지만 0번째가 아닌 4번째부터 시작하게 되면(끝에서부터 시작) 그럴 일이 없다.

            //인덱스가 [0]부터 [Count-1]까지이기 때문이다. 처음 시작이 0번째라서 그렇다.
            for(int i = students.Count-1; i>=0; i--)
            {
                if (students[i].Grade > 1)
                    students.RemoveAt(i);
            }

            for(int i = 0; i<students.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = $"{students[i].Name}학생 {students[i].Grade}학년";
                lbl.AutoSize = true;
                lbl.Location = new Point(130, 13 + 26 * i);
                Controls.Add(lbl);
            }
            

        }
    }
}
