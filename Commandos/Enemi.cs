using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Enemi
    {
        string Name;
        int Life = 100;
        string Status;

        public Enemi(string name, string status)
        {
            Name = name;
            Status = status;
        }

        public void Shout()
        {
            Console.WriteLine("I am an enemy!!");
        }
    }
}
