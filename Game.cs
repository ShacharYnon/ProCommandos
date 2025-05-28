using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class Game
    {
        public void Run()
        {
            CommandoFactory BildingCommandoSea = new CommandoFactory();
            BildingCommandoSea.Factory("Sea", "Shachar", "Alfa");
            CommandoFactory BildingCommandoAir = new CommandoFactory();
            BildingCommandoAir.Factory("Air", "Ori", "zi");
            CommandoFactory BildingCommandoLand = new CommandoFactory();
            BildingCommandoLand.Factory("Land", "Matan", "ssr");
            //--------------------------------------------------//
            WeaponFactory BildingWeaponTypeM = new WeaponFactory();
            BildingWeaponTypeM.FactoryWeapon("M-16", "COLT", 29);
            List<Weapon> listWeapon = BildingWeaponTypeM.GetWeaponList();
            BildingWeaponTypeM.FactoryWeapon("AK-47", "KALASHNIKOV", 30);
            M16 m16 = new M16("M-16", "COLT", 29);
            Console.WriteLine(m16);
            //---------------------------------------------------------//

        }
    }
}
