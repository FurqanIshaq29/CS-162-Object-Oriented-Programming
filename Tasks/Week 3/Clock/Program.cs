using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        class CLOCKTYPE
        {
            int hours;
            int minutes;
            int seconds;
            public CLOCKTYPE()
            {
                hours = 0;
                minutes = 0;
                seconds = 0;
            }

            public CLOCKTYPE(int h)
            {
                hours = h;
            }

            public CLOCKTYPE(int h, int m)
            {
                hours = h;
                minutes = m;
            }
            public CLOCKTYPE(int h, int m, int s)
            {
                hours = h;
                minutes = m;
                seconds = s;
            }

            public void incrementHours()
            {
                hours++;
            }

            public void incrementMinutes()
            {
                minutes++;
            }

            public void incrementSeconds()
            {
                seconds++;
            }

            public void printTime()
            {
                Console.WriteLine("{0} {1} {2}", hours, minutes, seconds);
            }

            /*  public bool isEqual(int h,int m,int s)
              {
                  if (hours == h && minutes == m && seconds == s)
                  {
                      return true;
                  }
                  else
                  {
                      return false;
                  }
              }

              public bool isEqual(CLOCKTYPE temp)
              {
                  if(hours ==temp.hours && minutes == temp.minutes && seconds == temp.seconds)
                  {
                      return true;
                  }
                  else
                  {
                      return false;
                  }
              }*/

            public void calculateTime(int h, int m, int s)
            {
                if (h == 0 && m == 0 && s == 0)
                {
                    hours = 24;
                    minutes = 0;
                    seconds = 0;
                }
                else
                {
                    hours = 23 - h;
                    minutes = 59 - m;
                    seconds = 60 - s;
                }
            }

        }
        static void Main(string[] args)
        {
            //default Constructor
            CLOCKTYPE empty_time = new CLOCKTYPE();
            Console.WriteLine("Empty time : ");
            empty_time.printTime();

            //parameterized function with just hours(one parameter)
            CLOCKTYPE hour_time = new CLOCKTYPE(8);
            Console.WriteLine("Hour time : ");
            hour_time.printTime();

            //parameterized function with minutes(two parameter)
            CLOCKTYPE minutes_time = new CLOCKTYPE(8, 10);
            Console.WriteLine("Minutes time : ");
            minutes_time.printTime();

            //parameterized function with seconds(three parameter)
            CLOCKTYPE full_time = new CLOCKTYPE(8, 10, 10);
            Console.WriteLine("Full time : ");
            full_time.printTime();

            //increment second
            full_time.incrementSeconds();
            Console.WriteLine("Full time (Increment Seconds) : ");
            full_time.printTime();

            //increment minutes
            full_time.incrementMinutes();
            Console.WriteLine("Full time (Increment Minutes) : ");
            full_time.printTime();

            //increment hours
            full_time.incrementHours();
            Console.WriteLine("Full time (Increment Hours) : ");
            full_time.printTime();

            /*  bool flag = full_time.isEqual(9, 11, 11);
              Console.WriteLine("Flag = {0}" , flag);

              CLOCKTYPE temp = new CLOCKTYPE(9,11,11);
              bool flag1 = full_time.isEqual(temp);
              Console.WriteLine("Object = {0}", flag1);
            */

            //given time
            
            full_time.calculateTime(0, 58, 59);
            full_time.printTime();





            Console.ReadKey();

        }
    }
}
