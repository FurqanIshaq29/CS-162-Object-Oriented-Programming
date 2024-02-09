using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS.BL

{
    class Student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<DegreeProgram> prefrences;
        public List<Subject> regSubject;
        public DegreeProgram regDegree;

        public Student(string na, int age, double fsc, double ecat, double merit , List<DegreeProgram> prefrences)
        {
            this.name = na;
            this.age = age;
            this.fscMarks = fsc;
            this.ecatMarks = ecat;
            this.merit = merit;
            regSubject = new List<Subject>();
        }

        public void calculateMerit()
        {
            this.merit = (((fscMarks / 1100)*0.45F) + ((ecatMarks / 400) *0.55)) * 100;

        }

        public bool regStudentSubject(Subject sub)
        {
            int sTCh = getCreditHours();
            if(regDegree != null && regDegree.isSubjectExists(sub) && sTCh + sub.creditHours <= 9)
            {
                regSubject.Add(sub);
            }
            return true;
        }

        public int getCreditHours()
        {
            int count = 0;
            foreach(Subject t in regSubject)
            {
                count = count + t.creditHours;
            }
            return count;
        }

        public float calculateFee()
        {
            float fee = 0;
            foreach(Subject t in regSubject)
            {
                fee = fee + t.subjectFee;
            }
            return fee;
        }
            

    }
}
