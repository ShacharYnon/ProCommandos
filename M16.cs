using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class M16 : Weapon, IShootable
    {
        public void Balls()
        {
            if (NumberOfBalls == 0)
            {
                Console.WriteLine("No bullets, reload.");
            }
        }

        public M16(string name, string manufacturer, int numBalls) : base(name, manufacturer, numBalls) 
        {
            NumberOfBalls = 29;
        }

        public void Shoot() 
        {
            NumberOfBalls = NumberOfBalls - 1;
            Console.WriteLine("Shoot");
            Console.WriteLine($"NumberOfBalls now is {NumberOfBalls}");
            Console.WriteLine("NumberOfBalls now is ");
        }

        int Range = 800;

        public override string ToString()
        {
            return base.ToString() + " Range: " + Range ;
        }
    }
}



