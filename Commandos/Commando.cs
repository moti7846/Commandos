using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        private string Name;
        public string CodeName { get; set; }
        public string[] Tools = { "Hammer", "Chisel", "Rope", "Bag", "Water bottle" };
        public string Status;

        public Commando(string name,string namecode)
        {
            Name = name;
            CodeName = namecode;
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
        public virtual void Attack()
        {
            Status = "attack";
            Console.WriteLine($"****_{CodeName}_****");
            Console.WriteLine("The commando attacks.");
        }
        public string SayName(string commanderRank)
        {
            if(commanderRank.Equals("general"))
            {
                return Name;
            }
            else if(commanderRank.Equals("clolnel"))
            {
                return CodeName;
            }
            return "The information is classified and you do not have access.";
        }

    }
}
