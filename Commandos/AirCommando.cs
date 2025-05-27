using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string namecode) : base (name , namecode) { }

        public void About()
        {
            Console.WriteLine("AirCommando");
        }

        public override void Attack()
        {
            Status = "attack";
            Console.WriteLine($"****_{CodeName}_****");
            Console.WriteLine("Airborne Commando Soldier Attacks.");
        }
    }
}
