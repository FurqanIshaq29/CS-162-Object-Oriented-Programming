using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    class Cat : Mammal
    {
        public Cat(string name) : base(name)
        {
        }
        public string Greets()
        {
            return "Meow";
        }
        public override string toString()
        {
            return "Cat[Mammal[Animal[name = " + this.name + "]]]";
        }
    }
}
