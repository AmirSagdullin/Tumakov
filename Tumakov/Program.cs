using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1: Приветствие по имени");
            Console.WriteLine();
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");

            Console.WriteLine();

            Console.WriteLine("Упражнение 2.2: Деление двух чисел");
            Console.WriteLine();
            Console.Write("Введите первое число: ");
            float first = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            float second = int.Parse(Console.ReadLine());
            float rez = first / second;
            if (second==0)
            {
                Console.WriteLine("Не делится!");
            }
            else {Console.WriteLine($"Результат деления: {rez}"); }

            Console.WriteLine();

            Console.WriteLine("Упражнение 2.1: Следующая буква");
            Console.WriteLine();
            Console.Write("Введите букву: ");
            char x = char.Parse(Console.ReadLine());
            x++;
            Console.WriteLine($"Следующая буква: {x}");

            Console.WriteLine();

            Console.WriteLine("Упражнение 2.2: Квадратное уравнение");
            Console.WriteLine();
            Console.Write("Введите коэффициент а: ");
            float a = int.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            float b = int.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент с: ");
            float c = int.Parse(Console.ReadLine());
            Console.WriteLine("Корни:");
            float discr;
            discr = b * b - 4 * a * c;
            if (discr > 0)
            {
                double x1 = (-b + Math.Sqrt(discr)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discr)) / (2 * a);
                Console.WriteLine($"{x1}");
                Console.WriteLine($"{x2}");
            }
            if (discr == 0)
            {
                double x1 = -b/(2 * a);
                Console.WriteLine($"{x1}");
            }
            if (discr < 0)
            {
                Console.WriteLine("Нет корней!");
            }
        }
    }
}
