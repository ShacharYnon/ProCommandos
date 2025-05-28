using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class WeaponFactory
    {
        List<Weapon> WeaponList = new List<Weapon>();

        public void FactoryWeapon(string Name , string Manufacturer , int NumberOfBalls)
        {
            WeaponList.Add(new Weapon(Name, Manufacturer, NumberOfBalls));
        }
        public List<Weapon> GetWeaponList()
        {
            return WeaponList;
        }
    }
}
