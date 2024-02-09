using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Staff : Person
    {
        private string school;
        private double pay;
        public Staff(string name,string address,string school,double pay) : base(name,address)
        {
            this.name = name;
            this.address = address;
            this.school = school;
            this.pay = pay;
        }

        public string getSchool()
        {
            return school;
        }

        public void setSchool(string school)
        {
            this.school = school;
        }

        public double getPay()
        {
            return pay;
        }

        public void setPay(double pay)
        {
            this.pay = pay;
        }
        
        public override string ToString()
        {
            return $"[Name] : {name} [Address] : {address} [School] : {school} [Pay] : {pay}";
        }
    }
}
