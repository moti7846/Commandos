using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string namecode) : base(name, namecode) { }

        public void About()
        {
            Console.WriteLine("SeaCommando");
        }

        public override void Attack()
        {
            Status = "attack";
            Console.WriteLine($"****_{CodeName}_****");
            Console.WriteLine("Marine commando soldier attacks.");
        }
    }
}
