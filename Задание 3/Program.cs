using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {

                double x, y, u;

                Console.WriteLine("Введите координаты X и Y через Enter:");

                bool ok;

                do { ok = Double.TryParse(Console.ReadLine(), out x); if (!ok) Console.WriteLine("Ошибка ввода координаты X!"); } while (!ok);
                do { ok = Double.TryParse(Console.ReadLine(), out y); if (!ok) Console.WriteLine("Ошибка ввода координаты Y!"); } while (!ok);

                if ((x * x + y * y) > 1 || y > x / 2)
                {
                    u = -3;
                }
                else
                {
                    u = y * y;
                }

                Console.WriteLine("Результат: " + u);

                Console.ReadKey();

        }

    }

}