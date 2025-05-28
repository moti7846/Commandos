using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class WeaponFactory
    {
        static WeaponFactory instans = null;
        List<Weapon> weapons = new List<Weapon>();

        private WeaponFactory() { }

        public static WeaponFactory GetInstans()
        {
            if (instans == null)
            {
                instans = new WeaponFactory();
            }
            return instans;
        }

        public void BuildWeapon(string name, string manufacturer, int number_balls)
        {
            weapons.Add(new Weapon(name, manufacturer, number_balls));
        }
    }
}
