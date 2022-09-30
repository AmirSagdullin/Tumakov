using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Задание 1. Перевод числа в дату");
        Console.WriteLine();
        Console.Write("Введите число (от 1 до 365): ");
        int date = int.Parse(Console.ReadLine());
        if (date > 0 && date <= 31)
        {
            Console.WriteLine($"{date} января");
        }
        else if (date >= 31 && date < 60)
        {
            Console.WriteLine($"{date - 30} февраля");
        }
        else if (date >= 60 && date < 91)
        {
            Console.WriteLine($"{date - 59} марта");
        }
        else if (date >= 91 && date < 121)
        {
            Console.WriteLine($"{date - 90} апреля");
        }
        else if (date >= 121 && date < 152)
        {
            Console.WriteLine($"{date - 120} мая");
        }
        else if (date >= 152 && date < 182)
        {
            Console.WriteLine($"{date - 151} июня");
        }
        else if (date >= 182 && date < 213)
        {
            Console.WriteLine($"{date - 181} июля");
        }
        else if (date >= 213 && date < 244)
        {
            Console.WriteLine($"{date - 212} августа");
        }
        else if (date >= 244 && date < 274)
        {
            Console.WriteLine($"{date - 243} сентября");
        }
        else if (date >= 274 && date < 305)
        {
            Console.WriteLine($"{date - 273} октября");
        }
        else if (date >= 305 && date < 335)
        {
            Console.WriteLine($"{date - 304} ноября");
        }
        else if (date >= 335 && date < 365)
        {
            Console.WriteLine($"{date - 334} декабря");
        }
        
        Console.WriteLine();

        Console.WriteLine("Задание 2. Задание 1 + исключение");
        Console.WriteLine();
        Console.Write("Введите число (от 1 до 365): ");
        int date2 = int.Parse(Console.ReadLine());
        while (date2 < 1 || date2 > 365)
        {
            Console.Write("Введите число (от 1 до 365): ");
            date2 = int.Parse(Console.ReadLine());
        }
        if (date2 > 0 && date2 <= 31)
        {
            Console.WriteLine($"{date2} января");
        } 
        else if (date2 >= 31 && date2 < 60)
        {
            Console.WriteLine($"{date2 - 30} февраля");
        }
        else if (date2 >= 60 && date2 < 91)
        {
            Console.WriteLine($"{date2 - 59} марта");
        }
        else if (date2 >= 91 && date2 < 121)
        {
            Console.WriteLine($"{date2 - 90} апреля");
        }
        else if (date2 >= 121 && date2 < 152)
        {
            Console.WriteLine($"{date2 - 120} мая");
        }
        else if (date2 >= 152 && date2 < 182)
        {
            Console.WriteLine($"{date2 - 151} июня");
        }
        else if (date2 >= 182 && date2 < 213)
        {
            Console.WriteLine($"{date2 - 181} июля");
        }
        else if (date2 >= 213 && date2 < 244)
        {
            Console.WriteLine($"{date2 - 212} августа");
        }
        else if (date2 >= 244 && date2 < 274)
        {
            Console.WriteLine($"{date2 - 243} сентября");
        }
        else if (date2 >= 274 && date2 < 305)
        {
            Console.WriteLine($"{date2 - 273} октября");
        }
        else if (date2 >= 305 && date2 < 335)
        {
            Console.WriteLine($"{date2 - 304} ноября");
        }
        else if (date2 >= 335 && date2 <= 365)
        {
            Console.WriteLine($"{date2 - 334} декабря");
        }
        */
        Console.WriteLine();

        Console.WriteLine("Домашнее задание 1. Предыдущее задание с учетом года");
        Console.WriteLine();
        Console.Write("Введите год: ");
        int year = int.Parse(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.Write("Введите число (от 1 до 366): ");
            int date2 = int.Parse(Console.ReadLine());
            while (date2 < 1 || date2 > 366)
            {
                Console.Write("Введите число (от 1 до 366): ");
                date2 = int.Parse(Console.ReadLine());
            }
            if (date2 > 0 && date2 <= 31)
            {
                Console.WriteLine($"{date2} января");
            }
            else if (date2 >= 31 && date2 < 61)
            {
                Console.WriteLine($"{date2 - 30} февраля");
            }
            else if (date2 >= 61 && date2 < 92)
            {
                Console.WriteLine($"{date2 - 60} марта");
            }
            else if (date2 >= 92 && date2 < 122)
            {
                Console.WriteLine($"{date2 - 91} апреля");
            }
            else if (date2 >= 122 && date2 < 153)
            {
                Console.WriteLine($"{date2 - 121} мая");
            }
            else if (date2 >= 153 && date2 < 183)
            {
                Console.WriteLine($"{date2 - 152} июня");
            }
            else if (date2 >= 183 && date2 < 214)
            {
                Console.WriteLine($"{date2 - 182} июля");
            }
            else if (date2 >= 214 && date2 < 245)
            {
                Console.WriteLine($"{date2 - 213} августа");
            }
            else if (date2 >= 245 && date2 < 275)
            {
                Console.WriteLine($"{date2 - 244} сентября");
            }
            else if (date2 >= 275 && date2 < 306)
            {
                Console.WriteLine($"{date2 - 274} октября");
            }
            else if (date2 >= 306 && date2 < 336)
            {
                Console.WriteLine($"{date2 - 305} ноября");
            }
            else if (date2 >= 336 && date2 <= 366)
            {
                Console.WriteLine($"{date2 - 335} декабря");
            }
        }
        else
        {
            Console.Write("Введите число (от 1 до 365): ");
            int date2 = int.Parse(Console.ReadLine());
            while (date2 < 1 || date2 > 365)
            {
                Console.Write("Введите число (от 1 до 365): ");
                date2 = int.Parse(Console.ReadLine());
            }
            if (date2 > 0 && date2 <= 31)
            {
                Console.WriteLine($"{date2} января");
            }
            else if (date2 >= 31 && date2 < 60)
            {
                Console.WriteLine($"{date2 - 30} февраля");
            }
            else if (date2 >= 60 && date2 < 91)
            {
                Console.WriteLine($"{date2 - 59} марта");
            }
            else if (date2 >= 91 && date2 < 121)
            {
                Console.WriteLine($"{date2 - 90} апреля");
            }
            else if (date2 >= 121 && date2 < 152)
            {
                Console.WriteLine($"{date2 - 120} мая");
            }
            else if (date2 >= 152 && date2 < 182)
            {
                Console.WriteLine($"{date2 - 151} июня");
            }
            else if (date2 >= 182 && date2 < 213)
            {
                Console.WriteLine($"{date2 - 181} июля");
            }
            else if (date2 >= 213 && date2 < 244)
            {
                Console.WriteLine($"{date2 - 212} августа");
            }
            else if (date2 >= 244 && date2 < 274)
            {
                Console.WriteLine($"{date2 - 243} сентября");
            }
            else if (date2 >= 274 && date2 < 305)
            {
                Console.WriteLine($"{date2 - 273} октября");
            }
            else if (date2 >= 305 && date2 < 335)
            {
                Console.WriteLine($"{date2 - 304} ноября");
            }
            else if (date2 >= 335 && date2 <= 365)
            {
                Console.WriteLine($"{date2 - 334} декабря");
            }
        }
    }
}