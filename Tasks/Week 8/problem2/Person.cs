using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    
    class Person
    {
        protected string name;
        protected string address;
        public Person(string name,string address)
        {
            this.name = name;
            this.address = address;
        }

        public virtual string getName()
        {
            return name;
        }

        public virtual void setName(string name)
        {
            this.name = name;
        }

        public virtual string getAddress()
        {
            return address;
        }

        public virtual void setAddress(string address)
        {
            this.address = address;
        }
        public override string ToString()
        {
            return $"[Name] : {name} [Address] : {address}";
        }

    }
}
