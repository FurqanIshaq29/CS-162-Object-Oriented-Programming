using System;

namespace Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Task1();
             Task2();
             Task3();
            Task4();
            Task5();
            Task6();*/
            Task7();
            

            Console.ReadKey();

        }


        static int add(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }

        static void Task1()
        {
            string str;
            float side, area;
            Console.WriteLine("enter side : ");
            str = Console.ReadLine();
            side = float.Parse(str);
            area = side * side;
            Console.WriteLine("Area : ");
            Console.WriteLine(area);

        }

        static void Task2()
        {
            string str;
            int marks;
            Console.WriteLine("Enter your marks : ");
            str = Console.ReadLine();
            marks = int.Parse(str);
            if(marks > 50)
            {
                Console.WriteLine("You are Passed");
            }

            else

            {
                Console.WriteLine("You are Fail");

            }


        }

        static void Task3()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Welcome Back!");

            }

        }

        static void Task4()
        {
            int number;
            int sum= 0;
            Console.WriteLine("Enter a number : ");
            number = int.Parse(Console.ReadLine());
            while (number != -1)
            {
                sum = sum + number;
                Console.WriteLine("Enter a number : ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The Total Sum : " + sum);
            Console.ReadLine();



        }

        static void Task5()
        {
            int number;
            int sum = 0;
            Console.WriteLine("Enter a number : ");
            number = int.Parse(Console.ReadLine());
            do
            {
                sum = sum + number;
                Console.WriteLine("Enter a number : ");
                number = int.Parse(Console.ReadLine());

            } while (number != -1);
            Console.WriteLine("The Sum : " + sum);
            Console.ReadLine();

        }

        static void Task6()
        {
            int[] number = new int[3];
            int largest = -1;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number : ");
                number[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                if (largest < number[i])
                {
                    largest = number[i];
                }
            }

            Console.WriteLine("Largest number is : " + largest);
            Console.ReadLine();
            

        }

        static void Task7()
        {
            int age;
            float washingPrice;
            float toyPrice;

            Console.WriteLine("Enter the age : ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Washing Price : ");
            washingPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the toyPrice : ");
            toyPrice = float.Parse(Console.ReadLine());

            int evenAge = age / 2;
            int oddAge = age / 2;
            if (age % 2 !=0) 
            {
                oddAge++;
            }

            float sum = 0;
            float toysPrice = (toyPrice * oddAge);

            for (int i = 1; i <=evenAge; i++)
            {
                sum = sum + (10 * i);
            }

            float total =(sum + toysPrice)- evenAge;
            if(total <washingPrice )
            {
                total = washingPrice - total;
                Console.WriteLine("No! "+ total);
                Console.ReadLine();
            }

            else
            {
                total = total - washingPrice;

                Console.WriteLine("Yes! " + total);
                Console.ReadLine();
            }
        }

        static void Task8()
        {

        }


    }
}
