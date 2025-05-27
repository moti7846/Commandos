using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Weapon
    {
        public string Name;
        public string Manufacturer;
        public int Number_balls;

        public Weapon(string name,string manufacturer,int number_balls)
        {
            Name = name;
            Manufacturer = manufacturer;
            Number_balls = number_balls;
        }

        public void Shoot()
        {
            if(Number_balls > 0)
            {
                Number_balls--;
                Console.WriteLine("Shooting was successfully carried out.");
                Console.WriteLine($"Your balance is: {Number_balls}");
            }
            else
            {
                Console.WriteLine("There are not enough bullets to shoot.");
            }
        }
    }
}
