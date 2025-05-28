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
            //Commando c = new Commando("comm", "1");
            //AirCommando a = new AirCommando("air", "1");
            //SeaCommando s = new SeaCommando("sea", "1");
            //Commando[] cas = { c, a, s };
            //foreach(Commando it in cas)
            //{
            //    it.Attack();
            //}
            ComandoFactory.GetInstans().BuildComandoer("Air","bjgn", "hfgjk");
         }
    }
}
