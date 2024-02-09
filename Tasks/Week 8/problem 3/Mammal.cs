using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
        }
        public override string toString()
        {
            return "Mammal[Animal[name = " + this.name + "]]";
        }
    }
}
