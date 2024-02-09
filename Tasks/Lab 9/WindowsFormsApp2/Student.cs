using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Student
    {
        private string name;
        private string id;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }

        public Student(string n,string id,int age)
        {
            this.name = n;
            this.id = id;
            this.age = age;
        }
    }
}
