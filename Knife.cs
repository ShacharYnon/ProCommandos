using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class Knife : IBreakable
    {
        string Name;
        string MetalType;
        string Manufacturer;
        string Color;
        int Weight;
        string Status ;

        public void status() 
        {
            Status = " Whole";
        }
        public void MaximumNumberOfBlows() { }

        public void NumberOfBlowSoFar() { }
    }
}
