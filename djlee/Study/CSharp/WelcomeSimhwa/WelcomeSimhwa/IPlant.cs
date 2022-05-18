using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeSimhwa
{
    public interface IPlant
    {
        int leafPower { get; set; }
        void leafcutter();
        void leafstorm();
    }
}
