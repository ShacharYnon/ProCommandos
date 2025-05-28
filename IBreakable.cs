using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal interface IBreakable
    {
        void status();
        void MaximumNumberOfBlows();
        void NumberOfBlowSoFar();
    }
}
