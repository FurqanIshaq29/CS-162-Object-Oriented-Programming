using System;
using System.Collections.Generic;
using System.Linq;

namespace IceCreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IceCream> ices = GetIceCreamsFromInput();
            Console.WriteLine(SweetestIceCream(ices));
        }

        public static List<IceCream> GetIceCreamsFromInput()
        {
            List<IceCream> iceCreams = new List<IceCream>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                string[] _params = Console.ReadLine().Split(' ');
                IceCream _iceCream = new IceCream(_params[0], int.Parse(_params[1]));
                iceCreams.Add(_iceCream);
            }

            return iceCreams;
        }

        public static int SweetestIceCream(List<IceCream> icecream)
        {
            int temp = 0;
            int large = 0;

            return temp;
        }
    }

    public class IceCream
    {
        int number;
        int price;
        

    }
}