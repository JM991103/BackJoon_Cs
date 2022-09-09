using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_Cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string[] arr = num.Split();

            int a = int.Parse(arr[0]);

            if (a >= 0 && a <= 100)
            {
                if (a >= 90)
                {
                    Console.WriteLine("A");
                }
                else if (a >= 80) 
                {
                    Console.WriteLine("B");
                }
                else if (a >= 70)
                {
                    Console.WriteLine("C");
                }
                else if (a >= 60)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
        }
    }
}