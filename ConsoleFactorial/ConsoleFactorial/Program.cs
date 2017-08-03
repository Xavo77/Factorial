using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial de un número");
            Console.WriteLine("Número:");
            int num = Convert.ToInt32(Console.ReadLine());
            float fac = 1;
            for (int i = num; i > 0; i--)
            {
                fac = fac * i;
            }
            Console.WriteLine("El factorial es: " + fac);
            Console.ReadLine();
        }
    }
}
