using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace Challenge_1
    {
        class Program
        {
            class clockType
            {
                public int seconds;
                public int minutes;
                public int hours;

                public clockType()
                {
                    seconds = 0;
                    minutes = 0;
                    hours = 0;
                }
                public clockType(int h)
                {
                    hours = h;
                }
                public clockType(int h, int m)
                {
                    hours = h;
                    minutes = m;
                }
                public clockType(int h, int m, int s)
                {
                    hours = h;
                    minutes = m;
                    seconds = s;
                }

                public void increamentHours()
                {
                    hours++;
                }
                public void increamentMinutes()
                {
                    minutes++;
                }
                public void increamentSeconds()
                {
                    seconds++;
                }

                public void isEqual(clockType time)
                {
                    if (hours == time.hours && minutes == time.minutes && seconds == time.seconds)
                    {
                        Console.WriteLine("Time is Equal");
                    }
                    else
                    {
                        int diff, cmp, newtym;
                        cmp = (time.hours * 3600) + (time.minutes * 60) + time.seconds;
                        newtym = (hours * 3600) + (minutes * 60) + seconds;
                        diff = cmp - newtym;
                        if (diff < 0)
                        {
                            diff = -diff;
                        }
                        Console.WriteLine("Time is not Equal!");
                        Console.WriteLine("Difference between time is: " + diff);
                    }
                }
                public int elapsedTime()
                {
                    int elapse = (hours * 3600) + (minutes * 60) + seconds;
                    return elapse;
                }
                public int remainingTime()
                {
                    int remaining = (3600 * 24) - elapsedTime();
                    return remaining;
                }
            }
            static void Main(string[] args)
            {
                clockType tim = new clockType();
                tim.hours = 12;
                tim.minutes = 12;
                tim.seconds = 32;
                printTime(tim);

                int elapse = tim.elapsedTime();
                int remain = tim.remainingTime();

                Console.WriteLine("Elapsed Time: " + elapse);
                Console.WriteLine("Remaining Time: " + remain);

                clockType newtime = new clockType();
                newtime.hours = 12;
                newtime.minutes = 12;
                newtime.seconds = 32;
                Console.WriteLine("Time Equal?: ");
                tim.isEqual(newtime);

                Console.ReadKey();
            }
            static void printTime(clockType time)
            {
                Console.WriteLine(time.hours + " " + time.minutes + " " + time.seconds);
            }

        }
    }

}
    }
}
