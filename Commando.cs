using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class Commando
    {
        private string Name ;
        public string NameCode { get; set;}
        public string[] Tools = { "Water bottle", "Bag", "Rope", "Chisel", "Hammer" };
        public string Status = "";

        public Commando(string name, string namecode)
        {
            Name = name;
            NameCode = namecode;
        }

        public void Walk()
        {
            Console.WriteLine("The soldier walks");
            Status = "Walk";
        }
        public void Hide()
        {
            Status = "Hide";
            Console.WriteLine($"The soldier is {Status}");
        }
        public virtual void Attack()
        {
            Console.WriteLine($"The soldier {NameCode} attacks");
        }

        public string SayName(string commanderRank)
        {
            commanderRank = commanderRank.ToUpper();
            if (commanderRank.Equals("GENERAL"))
            {
                return Name;
            }
            else if (commanderRank.Equals("COLONEL"))
            {
                return NameCode;
            }
            else
            {
                return "This information is  CLASSIFIED!!! .";
            }

               

            
        }

        public void SetNameCode(string nameCode)
        {
            NameCode = nameCode;
        }
     }
}


