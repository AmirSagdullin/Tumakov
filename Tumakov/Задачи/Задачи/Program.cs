using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Threading.Timer;

namespace For_Dina
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Голова в форточке");
            Console.WriteLine();
            Console.Write("Введите длину форточки (см): ");
            double dlina = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину форточки (см): ");
            double shirina = double.Parse(Console.ReadLine());
            Console.Write("Введите диаметр головы (см): ");
            double diametr = double.Parse(Console.ReadLine());
            if (dlina - 2 >= diametr && shirina - 2 >= diametr)
            {
                Console.WriteLine("Вася сможет высунуть голову в форточку");
            }
            else
            {
                Console.WriteLine("Вася не сможет высунуть голову в форточку");
            }

            Console.WriteLine();

            Console.WriteLine("Задание 2. Таблица умножения");
            Console.WriteLine();
            Console.Write("Введите число n (от 1 до 9): ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {n} = {i * n}");
            }

            Console.WriteLine();

            Console.WriteLine("Задание 3. Проверка делимости");
            Console.WriteLine();
            Console.Write("Введите целое число: ");
            int chislo = int.Parse(Console.ReadLine());
            if (chislo % 3 == 0 && chislo % 5 != 0)
            {
                Console.WriteLine("Бэнг");
            }
            else if (chislo % 5 == 0 && chislo % 3 != 0)
            {
                Console.WriteLine("Бум");
            }
            else if (chislo % 3 == 0 && chislo % 5 == 0)
            {
                Console.WriteLine("БэнгБум");
            }
            else
            {
                Console.WriteLine("Мимо");
            }

            Console.WriteLine();

            Console.WriteLine("Задание 4. Проверить верхний регистр строки");
            Console.WriteLine();
            Console.Write("Введите строку, состоящую из букв: ");
            string stroka = Console.ReadLine();
            if (stroka == stroka.ToUpper())
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine();

            Console.WriteLine("Задание 5. Количество овец");
            Console.WriteLine();
            Console.Write("Введите натуральное число: ");
            int nat_ch = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nat_ch; i++)
            {
                Console.Write($"{i} овца... ");
            }
        }

    }
}
