using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ_6
{
    class Program
    {
        public delegate double Delegate(double x, double y);

        public static void Table(Delegate F, double x, double y, double a)
        {
            while (y <= a)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", x, y, F(x, y));
                y += 0.1;
            }
            Console.WriteLine("-----------------------------------------");
        }

        public static double Fun(double x, double y)
        {
            return x * y * y;
        }

        public static double Sin (double x, double y)
        {
            return x * Math.Sin(y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа выводит таблицы функций a*b^2 и a*sin(b).");
            Console.WriteLine("Введите переменную [a]");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите переменную [b]");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bведите переменную [c]. Не может быть меньше [b]");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Таблица функции a*b^2");
            Table(Fun, a, b, c);
            Console.WriteLine("Таблица функции a*sin(b)");
            Table(Sin, a, b, c);
            Console.ReadKey();
            
        }
        
    }
}
