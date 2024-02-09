using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class DegreeProgram
    {
        public string degreeName;
        public float degreeDuration;
        List<Subject> subjects;
        int seats;
        public DegreeProgram(string degreeName, float degreeDuration,int seats)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.seats = seats;
            subjects = new List<Subject>();
        }

        public bool isSubjectExists(Subject sub)
        {
            foreach(Subject t in subjects)
            {
                if(t.code == sub.code)
                {
                    return true;
                }
            }
            return false;
        }

        public bool addSubject(Subject sub)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + sub.creditHours <= 20)
            {
                subjects.Add(sub);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int calculateCreditHours()
        {
            int count = 0;
            for(int i = 0; i < subjects.Count; i++)
            {
                count = count + subjects[i].creditHours;
            }
            return count;
        }
    }
}
