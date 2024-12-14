using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_sol
{
    public class Problem
    {
        public int Number { get; }
        public string Description { get; }

        public Problem(int number, string description)
        {
            Number = number;
            Description = description;
        }
    }
}
