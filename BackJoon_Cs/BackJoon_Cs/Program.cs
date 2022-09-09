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
            string num1 = Console.ReadLine();
            string[] arr = num1.Split();

            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);

            if (b < 45)
            {
                if (a == 0)
                {
                    a = 23;
                    b += 60;
                }
                else
                {
                    a -= 1;
                    b += 60;
                }
            }
        

            Console.WriteLine($"{a} {b - 45}");
        }
    }
}