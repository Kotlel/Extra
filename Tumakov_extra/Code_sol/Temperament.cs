using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_sol
{
    public class Temperament
    {
        public int Scandalousness { get; }
        public int Intelligence { get; }

        public Temperament(int scandalousness, int intelligence)
        {
            Scandalousness = scandalousness;
            Intelligence = intelligence;
        }
    }
}
