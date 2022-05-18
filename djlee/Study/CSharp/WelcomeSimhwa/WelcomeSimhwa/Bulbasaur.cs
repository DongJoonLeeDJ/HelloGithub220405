using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeSimhwa
{
    public class Bulbasaur : Animal, IPlant, IPoision
    {
        public int leafPower { get; set ; }
        public int venomPower { get; set; }

        public override void attack()
        {
            cry();
            System.Windows.Forms.MessageBox.Show("이상해씨 공격해라~ 씨씨씨~~~"+age+"살 최초의 공격!");
        }

        public override void charming()
        {
            System.Windows.Forms.MessageBox.Show("이상해씨 애교부리기~~" + masterName+"의 마음에 들었다.");
        }

        public void leafcutter()
        {
            System.Windows.Forms.MessageBox.Show(leafPower+"의 공격력을 실어서 리프커퍼!");
        }

        public void leafstorm()
        {
            System.Windows.Forms.MessageBox.Show(leafPower + "의 공격력을 실어서 리프스톰!");
        }

        public void venomBom()
        {
            System.Windows.Forms.MessageBox.Show(venomPower + "의 공격력을 실어서 독폭탄!");
        }

        public void venomShork()
        {
            System.Windows.Forms.MessageBox.Show(venomPower + "의 공격력을 실어서 베놈쇼크!");
        }
    }
}
