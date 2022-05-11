using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCarProgram
{
    public class ParkingCar
    {
        public int ParkingSpot { get; set; }//주차공간번호, PK
        public string CarNumber { get; set; } //차 번호
        public string DriverName { get; set; } //운전자명
        public string PhoneNumber { get; set; } //운전자 연락처
        public DateTime ParkingTime { get; set; } //주차 시작 시간
    }
}
