using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class EnemyFactory
    {
        static EnemyFactory instans = null;
        List<Enemi> enemies = new List<Enemi>();

        private EnemyFactory() { }

        public static EnemyFactory GetInstans()
        {
            if (instans == null)
            {
                instans = new EnemyFactory();
            }
            return instans;
        }

        public void BuildEnemi(string name, string status)
        {
            enemies.Add(new Enemi(name, status));
        }
    }
}
