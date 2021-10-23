using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону куба");
            int a = Convert.ToInt32(Console.ReadLine());
            double Per, Squard;
            Param(a, out Per, out Squard);
            Console.WriteLine("Периметр куба равен {0}. Площадь куба равна {1}", Per, Squard);
            Console.ReadKey();
        }
        static void Param(int a, out double Per, out double Squard)
        {
            Per = 12 * a;
                Squard = Math.Pow(a, 2)*6;

        }
    }
}
