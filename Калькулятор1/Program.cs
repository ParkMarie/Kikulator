using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор1
{
    class Program
    {
        public static int a;

        static void Main(string[] args)
        {
            int one, two;

            do
            {
                Console.WriteLine("Выберите какую операцию хотите выполнить:");
                Console.WriteLine("1.Сложить два числа");
                Console.WriteLine("2.Вычесть первое из второго");
                Console.WriteLine("3.Перемножить два числа");
                Console.WriteLine("4.Разделить первое на второе");
                Console.WriteLine("5.Возвести в степень N перовое число");
                Console.WriteLine("6.Найти квадратный корень из числа");
                Console.WriteLine("7.Найти 1 % от числа");
                Console.WriteLine("8.Найти факториал из числа");
                Console.WriteLine("9.Выйти из программы");

                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.WriteLine("Введите первое число:");
                        one = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        two = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(one + two);
                        break;
                    case 2:
                        Console.WriteLine("Введите  первое число:");
                        one = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        two = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(one - two);
                        break;
                    case 3:
                        Console.WriteLine("Введите первое число:");
                        one = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        two = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(one * two);
                        break;
                    case 4:
                        Console.WriteLine("Введите первое число:");
                        one = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        two = Convert.ToInt32(Console.ReadLine());
                        if (two == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя :(");
                        }
                        else
                        {
                            Console.WriteLine(one / two);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Введите число:");
                        one = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите степень, в которую хотите возвести число:");
                        two = Convert.ToInt32(Console.ReadLine());
                        double s = Math.Pow(one, two);
                        Console.WriteLine(s);
                        break;
                    case 6:
                        Console.WriteLine("Введите число:");
                        one = Convert.ToInt32(Console.ReadLine());
                        double k = Math.Sqrt(one);
                        Console.WriteLine(k);
                        break;
                    case 7:
                        Console.WriteLine("Введите число:");
                        one = Convert.ToInt32(Console.ReadLine());
                        double p = one / 100;
                        Console.WriteLine(p + "%");
                        break;
                    case 8:
                        int f = 1;
                        Console.WriteLine("Введите число:");
                        one = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= one; i++)
                        {
                            f *= i;
                        }
                        Console.WriteLine(f);
                        break;
                    case 9:
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Такой операции нет :( Выберите существующую операцию :3");
                        break;

                }





            } while (a != 9);
            Console.WriteLine("Хорошего дня! <3");



        }
    }
}
            