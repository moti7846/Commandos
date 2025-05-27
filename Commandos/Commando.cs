using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        public string Name;
        public string NameCode;
        public string[] Tools = { "Hammer", "Chisel", "Rope", "Bag", "Water bottle" };
        public string Status;

        public Commando(string name,string namecode)
        {
            Name = name;
            NameCode = namecode;
        }
        public void Walk()
        {
            Status = "walk";
            Console.WriteLine("The soldier is leaving.");
            //Console.WriteLine($"The soldier is {Status}.");
        }
        public void Hide()
        {
            Status = "hide";
            Console.WriteLine("The soldier is hiding.");
            //Console.WriteLine($"The soldier is {Status}.");
        }
        public void Attack()
        {
            Status = "attack";
            Console.WriteLine($"****_{NameCode}_****");
            Console.WriteLine("The commando attacks.");
        }

    }
}
