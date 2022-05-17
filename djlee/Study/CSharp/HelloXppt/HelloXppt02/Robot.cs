using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXppt02
{
    public abstract class Robot
    {
        abstract public void eStop(); //Robot을 구현했다면
        //비상정지는 당연히 구현해야 한다.
    }
}
