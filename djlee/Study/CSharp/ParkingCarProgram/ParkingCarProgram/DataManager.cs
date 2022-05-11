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
            //using의 역할
            //using 구문이 끝나면 Dispose함 즉 메모리를 destroy한다(삭제한다)
            //끝에 있는 true의 의미
            //append 를 true로 하겠다. (append 확장)
            //contents를 덮어쓰지 않고 기존 내용의 밑에다가 새롭게 추가하는 방식으로 가겠다
            //true부분이 생략되거나 false일 경우에는 PrintLog 호출할 때마다
            //ParkingHistory.txt에 새로 들어온 contents 내용만 있고 나머진 지워짐...
            using (StreamWriter writer = new StreamWriter(@"ParkingHistory\ParkingHistory.txt", true))
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
