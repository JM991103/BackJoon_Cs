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
            int.TryParse(num1, out int a);
            string num2 = Console.ReadLine();
            int.TryParse(num2, out int b);

           
            if (a > 0 && b > 0)
            {
                Console.WriteLine("1");
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine("2");
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("4");
            }
        }
    }
}