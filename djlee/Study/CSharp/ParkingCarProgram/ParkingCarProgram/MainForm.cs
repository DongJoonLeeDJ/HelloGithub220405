using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCarProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            try
            {
                //프로그램을 시작하면 가장 첫번째 주차공간에 있는 정보들을 TextBox에 적는다.
                textBox_parkingSpot.Text = DataManager.Cars[0].ParkingSpot.ToString();//여기서 static DataManager() 호출 됨!!!
                textBox_carNumber.Text = DataManager.Cars[0].CarNumber;
                textBox_driverName.Text = DataManager.Cars[0].DriverName;
                textBox_phoneNumber.Text = DataManager.Cars[0].PhoneNumber;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            //datagridview의 dataSource 변경
            if (DataManager.Cars.Count > 0)
                dataGridView_parkingManager.DataSource = DataManager.Cars;

            //현재 시각 표시
            //HH : 24시간기준, hh:12시간기준
            //MM : Month, mm:minute
            label_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");


            //주차공간 추가
            button_add.Click += delegate (object s, EventArgs e)
            {
                //TryParse는 Parse보다 좀 더 안전한 변환기
                //textBox_spotNumber.Text에 숫자가 아닌 것이 있다면 parkingSpot 변수에 0을 대입해주고
                //TryParse 자체는 false를 반환한다.
                //Visual Studio 2015까진 out int 이렇게 동시에 못 썼고,
                //int 변수 선언하고 나서 out 옆에 그 변수를 적을 수 있었다.
                //즉 int parkingSpot 선언 후 그 이후에 int.TryParse(textBox_spotNumber.Text, out parkingSpot) 이렇게 적어야 했다.
                if (int.TryParse(textBox_spotNumber.Text, out int parkingSpot)==false)
                {
                    MessageBox.Show("주차공간번호는 숫자여야 합니다.");
                    return;
                }
                if(parkingSpot<=0)
                {
                    MessageBox.Show("주차공간번호는 1 이상의 값이어야 합니다.");
                    return;
                }

                string contents = string.Empty;
                if (DataManager.Save("insert", parkingSpot, out contents))
                    button_refresh.PerformClick(); //refresh  버튼을 누르는 거임
                WriteLog(contents);//화면이랑 text파일에 글 적는 거
            };

            //주차공간 삭제
            button_remove.Click += (s, e) =>
            {
                //좀 옛날 스타일
                int parkingSpot=0;
                if (int.TryParse(textBox_spotNumber.Text, out parkingSpot) == false)
                {
                    MessageBox.Show("주차공간번호는 숫자여야 합니다.");
                    return;
                }
                if (parkingSpot <= 0)
                {
                    MessageBox.Show("주차공간번호는 1 이상의 값이어야 합니다.");
                    return;
                }

                string contents = string.Empty;
                if (DataManager.Save("delete", parkingSpot, out contents))
                    button_refresh.PerformClick(); //refresh  버튼을 누르는 거임
                WriteLog(contents);//화면이랑 text파일에 글 적는 거
            };
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            label_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }

        //로그파일도 만들고 화면에 기록도 적는 부분
        private void WriteLog(string contents)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")}]{contents}";
            DataManager.PrintLog(logContents);
            MessageBox.Show(contents);
            listBox_logPrint.Items.Insert(0, logContents); //최신 내용이 위로 올라감
            //listBox_logPrint.Items.Add(logContents) 했다면 최신 내용이 밑으로 내려감
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            DataManager.Load();
            dataGridView_parkingManager.DataSource = null;
            if(DataManager.Cars.Count>0)
                dataGridView_parkingManager.DataSource = DataManager.Cars;

        }
    }
}
