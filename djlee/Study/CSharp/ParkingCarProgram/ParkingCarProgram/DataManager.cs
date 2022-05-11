using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCarProgram
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();
        static DataManager() //정적 생성자는 한 번만 호출
        {
            Load();
        }

        //txt파일 형태로 로그를 남기는 메소드
        public static void PrintLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("ParkingHistory"); //폴더명
            if(!di.Exists)
            {
                di.Create(); //해당 폴더가 없으면 생성함
            }
            using(StreamWriter writer = new StreamWriter(@"ParkingHistory\ParkingHistory.txt", true))
            {
                writer.WriteLine(contents);
            }
        }

        public static void Load()
        {
            try
            {
                DBHelper.selectQuery();
                Cars.Clear(); //기존에 내용 지움
                foreach (DataRow item in DBHelper.dt.Rows)
                {
                    ParkingCar temp = new ParkingCar();
                    temp.ParkingSpot = int.Parse(item["ParkingSpot"].ToString());
                    temp.CarNumber = item["CarNumber"].ToString();
                    temp.DriverName = item["DriverName"].ToString();
                    temp.PhoneNumber = item["PhoneNumber"].ToString();
                    //ParkingTime이 null값 일 경우은 ToString하면 ""이 나온다.
                    //그땐 new DateTime() - 0001년도... 이런 값을 넣어주고(기본 값)
                    //그게 아니면 현재 날짜를 집어넣어주는 구조
                    temp.ParkingTime = item["ParkingTime"].ToString() == "" 
                        ? new DateTime() : DateTime.Parse(item["ParkingTime"].ToString());

                    Cars.Add(temp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
