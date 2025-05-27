using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCommandos
{
    internal class Weapon
    {
        string Name = "";
        string Manufacturer = "";
        int NumberOfBalls = 0;

        public Weapon(string name, string manufacturer, int numberOfBalls)
        {
            Name = name;
            Manufacturer = manufacturer;
            NumberOfBalls = numberOfBalls;
        }

        public void Shoot()
        {
            NumberOfBalls = NumberOfBalls - 1;
            Console.WriteLine("Shoot");
            Console.WriteLine($"NumberOfBalls now is {NumberOfBalls}");
        }

    }
}
