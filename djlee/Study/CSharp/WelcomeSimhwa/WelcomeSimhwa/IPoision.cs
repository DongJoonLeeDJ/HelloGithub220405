using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeSimhwa
{
    public interface IPoision
    {
        int venomPower { get; set; }
        void venomShork();
        void venomBom();
    }
}
