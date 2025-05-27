using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando c1 = new Commando("Shachar", "Alfa");
            AirCommando Ac = new AirCommando("or", "ppp");
            SeaCommando Sc = new SeaCommando("bar", "639");
            Commando[] Soldiers = {Ac ,c1 ,Sc };
            foreach(Commando item in  Soldiers)
            {
                item.Attack();
            }
        }
    }
}
