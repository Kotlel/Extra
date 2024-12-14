using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Code_sol
{
    public class Resident
    {
        private static int passportNumCounter = 0;
        public string Name { get; }
        public int PassportNumber;
        public Problem Problem { get; }
        public Temperament Temperament { get; }

        public Resident(string name, Problem problem, Temperament temperament)
        {
            Name = name;
            PassportNumber = passportNumCounter++;
            Problem = problem;
            Temperament = temperament;
        }
    }
}
