using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
    //Губарь Артём
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            // Запомним время в начале обработки данных
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("C:\\Users\\tatmi\\Downloads\\students.csv");
            int n = 0; //студенты на 5 и 6 курсе
            int m = 0; //студенты от 18 до 20 лет
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(s[1] + " " + s[0]);
                    if (int.Parse(s[6]) >= 5) n++;
                    if (int.Parse(s[5]) <= 20) m++;
                }
                catch
                {
                }
            }
          
            sr.Close();
            list.Sort();
            Console.WriteLine("Всего студентов:{0}", list.Count);
            Console.WriteLine("Количество студентов учащихся на 5 и 6 курсах:{0}", n);
            Console.WriteLine("Количество студентов от 18 до 20:{0}", m);
            foreach (var v in list) Console.WriteLine(v);
            // Вычислим время обработки данных
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }



}
