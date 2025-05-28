using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class Stone
    {
        string Name;
        int Weight;
        string Color;
        int NumberOfBlowsUntilBreakage ;
        string Status;
        int NumberOfBlowSoFar;


        public void status()
        {
            Status = " Whole";
        }
        public void MaximumNumberOfBlows()
        {
            NumberOfBlowsUntilBreakage = 5 ;
        }

        public void numberOfBlowSoFar() 
        {
            NumberOfBlowSoFar = 0 ;
        }
    }
}
