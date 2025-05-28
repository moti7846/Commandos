using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class GAME
    {
        static GAME instans = null;
        List<List<object>> weapons = new List<List<object>>
        {
            new List<object> { "M4A1 Carbine", "Colt's Manufacturing Company", 30 },
            new List<object> { "AK-47", "Kalashnikov Concern", 30 },
            new List<object> { "Glock 19", "Glock Ges.m.b.H.", 15 },
            new List<object> { "FN SCAR-H", "FN Herstal", 20 },
            new List<object> { "MP5", "Heckler & Koch", 30 }
        };
        List<List<object>> comandos = new List<List<object>>
        {
            new List<object> { "Blake", "Air", "Shadow" },
            new List<object> { "Mason", "Sea", "Viper" },
            new List<object> { "Ryder", "Sea", "Falcon" },
            new List<object> { "Cole", "Air", "Ghost" },
            new List<object> { "Jaxon", "Normal", "Raptor" }
        };
        List<List<object>> enemies = new List<List<object>>
        {
            new List<object> { "Rami" , "Live"},
            new List<object> { "Farid" , "Live"},
            new List<object> { "Nasser" , "Live"},
            new List<object> { "Khaled" , "Live"},
            new List<object> { "Amir" , "Live"}
        };



        private GAME() { }

        public static GAME GetInstans()
        {
            if (instans == null)
            {
                instans = new GAME();
            }
            return instans;
        }

        public void starrt()
        {
            for(int i = 0;i<5;i++)
            {
                WeaponFactory.GetInstans().BuildWeapon((string)weapons[i][0], (string)weapons[i][1], (int)weapons[i][2]);
                EnemyFactory.GetInstans().BuildEnemi((string)enemies[i][0], (string)enemies[i][1]);
                ComandoFactory.GetInstans().BuildComandoer((string)comandos[i][0], (string)comandos[i][1], (string)weapons[i][2]);
            }
        }
    }
}
