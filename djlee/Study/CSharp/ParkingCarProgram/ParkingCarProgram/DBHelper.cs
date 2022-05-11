using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCarProgram
{
    //DB 연결
    //DB에 쿼리 보내기(CRUD)
    public class DBHelper
    {
        private static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        //DB 연결 후 쿼리 날리고 다시 DB 닫음
        private static void ConnectDB()
        {
            conn.ConnectionString
                = "Data Source=(local); initial Catalog=MyCarManagerDB; " +
                "integrated Security=SSPI;" +
                "Timeout=3";
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        //메소드를 두 가지 방식으로 호출하게 해줌
        //selectQuery() 이렇게 매개변수 없이 호출하면 parkingSpot에 -1이 들어감
        //selectQuery(num) 숫자 집어넣어서 호출하면 parkingSpot에 num이 들어감
        public static void selectQuery(int parkingSpot=-1)
        {
            ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                if (parkingSpot == -1)
                    cmd.CommandText = "select * from ParkingCar";
                else
                    cmd.CommandText = "select * from ParkingCar where ParkingSpot=" + parkingSpot;

                da = new SqlDataAdapter(cmd); //SqlDataAdapter를 통해서 결과를 구한다.
                ds = new DataSet();
                da.Fill(ds, "ParkingCar"); //SqlDataAdapter를 통해 DataSet에 결과를 저장
                dt = ds.Tables[0]; //DataTable에 그 결과 중 하나를 저장. 

                //select 문이 지금은 하나라서 ds.Tables에도 하나의 결과만 있을 것이다.
                //select 문 구성에 따라서 여러 개의 테이블을 한 번에 ds에 다 저장하는 경우도 있다.
                //그 경우에 ds.Tables의 길이가 2개 이상이 될 수도 있다.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                conn.Close(); //DB는 반드시 닫아야 한다.
            }
        }
    }
}
