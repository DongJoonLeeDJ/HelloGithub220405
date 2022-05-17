using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseAPI
{
    //위치 정보 (위치이름, 그 위치의 x좌표, y좌표)
    public class Locale
    {
        public string Name { get; set; }
        public double Lat { get; set; } //Y
        public double Lng { get; set; } //X

        public Locale(string name, double lat, double lng)
        {
            Name = name;
            Lat = lat;
            Lng = lng;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
