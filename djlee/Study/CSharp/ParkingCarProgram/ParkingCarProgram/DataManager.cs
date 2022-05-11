using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCarProgram
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();
        static DataManager()
        {
            Load();
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
