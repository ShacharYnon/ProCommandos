using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string nameCode) : base(name, nameCode)
        {
            Console.WriteLine("I can swim.");
        }
        public override void Attack()
        {
            Console.WriteLine("Sea commando attacks! ");
        }
    }
}
