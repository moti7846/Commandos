using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class ComandoFactory
    {
        static ComandoFactory instans = null;
        List<Commando> commandos = new List<Commando>();

        private ComandoFactory() { }

        public static ComandoFactory GetInstans()
        {
            if (instans == null)
            {
                instans = new ComandoFactory();
            }
            return instans;
        }

        public void BuildComandoer(string type ,string name, string namecode)
        {
            switch(type)
            {
                case "Air":
                    commandos.Add(new AirCommando(name, namecode));
                    break;
                case "Sea":
                    commandos.Add(new SeaCommando(name, namecode));
                    break;
                default:
                    commandos.Add(new Commando(name, namecode));
                    break;  
            }
        }
    }
}
