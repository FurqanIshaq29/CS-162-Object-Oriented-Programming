using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fees;
        public Student(string name,string address,string program,int year,double fees) : base(name,address)
        {
            this.name = name;
            this.address = address;
            this.program = program;
            this.year = year;
            this.fees = fees;
        }

        public string getProgram()
        {
            return program;
        }

        public void setProgram(string program)
        {
            this.program = program;
        }

        public int getYear()
        {
            return year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public double getFees()
        {
            return fees;
        }

        public void setFees(double fees)
        {
            this.fees = fees;
        }
        public override string ToString()
        {
            return $"[Name] : {name} [Address] : {address} [Program] : {program} [year] : {year} [Fees] : {fees}";
        }
    }
}
