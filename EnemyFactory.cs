using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class EnemyFactory
    {
        List<Enemy> EnemyList = new List<Enemy>();

        public void Factory()
        {
            EnemyList.Add(new Enemy());
        }
    }
}
