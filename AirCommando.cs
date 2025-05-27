using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name ,string nameCode) : base(name ,nameCode) 
        {
            Console.WriteLine("I can fly.");
        }
        public override void Attack()
        {
            Console.WriteLine("Air commando attacks! ");
        }

    }
}
