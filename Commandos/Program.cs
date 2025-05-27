using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Commando a = new Commando("moti", "11224");
            //a.Walk();
            //a.Hide();
            //a.Attack();

            Weapon b = new Weapon("moti", "sos", 5);
            b.Shoot();
            b.Shoot();
            b.Shoot();
            b.Shoot();
            b.Shoot();
            b.Shoot();
            b.Shoot();
        }
    }
}
