using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    class Dog : Mammal
    {
        public Dog(string name) : base(name)
        {
        }
        public string Greets()
        {
            return "Woof";
        }
        public override string toString()
        {
            return "Dog[Mammal[Animal[name = " + this.name + "]]]";
        }
    }
}
