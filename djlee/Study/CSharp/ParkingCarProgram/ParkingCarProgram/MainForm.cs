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
    }
}
