using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class CommandoFactory
    {
        List<Commando> CommandoList = new List<Commando>();
        
        public void Factory(string type,string Name,string CodeName )
        {
            switch (type)
            {
                case "Sea":
                    CommandoList.Add(new SeaCommando(Name,CodeName));
                    break;

                case "Air":
                    CommandoList.Add(new AirCommando(Name, CodeName));
                    break;

                case "Land":
                    CommandoList.Add(new Commando(Name, CodeName));
                    break;
            }
        }
        public List<Commando> GetCommandoList()
        {
            return CommandoList;
        }
    }
}
