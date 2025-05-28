using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class Enemy
    {
        private string Name;
        private int Life = 100 ;
        private string Status = "Alive";
        
        public void Scream()
        {
            Console.WriteLine("I am an enemy!!! ");
        }
        

    }
}
