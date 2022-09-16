using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace For_Dina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1. Число е");
            Console.WriteLine();
            Console.WriteLine("e = 2.7");

            Console.WriteLine();

            Console.WriteLine("Задание 2. Вывести числа");
            Console.WriteLine();
            Console.WriteLine("50");
            Console.WriteLine("10");

            Console.WriteLine();

            Console.WriteLine("Задание 3. Рандомные числа в столбик");
            Console.WriteLine();
            Random rnd = new Random();
            int value = rnd.Next();
            int value1 = rnd.Next();
            int value2 = rnd.Next();
            int value3 = rnd.Next();
            Console.WriteLine(value);
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);

            Console.WriteLine();

            Console.WriteLine("Задание 4. Число, больше введенного на 10");
            Console.WriteLine();
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine(q+10);
            
            Console.WriteLine();

            Console.WriteLine("Задание 5. Периметр квадрата");
            Console.WriteLine();
            Console.Write("Введите сторону квадрата: ");
            float side = float.Parse(Console.ReadLine());
            float perimetr = side * 4;
            Console.WriteLine(perimetr);
            
            Console.WriteLine();

            Console.WriteLine("Задание 6. Длина окружности и площадь круга");
            Console.WriteLine();
            Console.Write("Введите радиус окружности: ");
            float radius = float.Parse(Console.ReadLine());
            double dlina_okr = 2 * 3.14 * radius;
            double ploschad_okr = 3.14 * radius * radius;
            Console.WriteLine($"Длина окружности: {dlina_okr}");
            Console.WriteLine($"Площадь окружности: {ploschad_okr}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 7. Найти y=cos(x)");
            Console.WriteLine();
            Console.Write("Введите аргумент: ");
            double x = float.Parse(Console.ReadLine());
            double y = Math.Cos(x);
            Console.WriteLine($"y = {y}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 8. Периметр равнобедренной трапеции");
            Console.WriteLine();
            Console.Write("Введите верхнее основание трапеции: ");
            double up_osn = float.Parse(Console.ReadLine());
            Console.Write("Введите нижнее основание трапеции: ");
            double down_osn = float.Parse(Console.ReadLine());
            Console.Write("Введите высоту трапеции: ");
            double height = float.Parse(Console.ReadLine());
            double bok = Math.Sqrt(Math.Pow(((down_osn - up_osn)/2), 2.0) + Math.Pow(height, 2.0));
            double per_trap = 2*bok + up_osn + down_osn;
            Console.WriteLine($"Периметр: {per_trap}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 9. Стоимость покупки");
            Console.WriteLine();
            Console.Write("Введите массу конфет: ");
            double mass_konf = float.Parse(Console.ReadLine());
            Console.Write("Введите массу печенья: ");
            double mass_pech = float.Parse(Console.ReadLine());
            Console.Write("Введите массу яблок: ");
            double mass_apple = float.Parse(Console.ReadLine());
            Console.Write("Введите стоимость кг конфет: ");
            double stoim_konf = double.Parse(Console.ReadLine());
            Console.Write("Введите стоимость кг печенья: ");
            double stoim_pech = double.Parse(Console.ReadLine());
            Console.Write("Введите стоимость кг яблок: ");
            double stoim_apple = double.Parse(Console.ReadLine());
            double all_stoim = mass_konf * stoim_konf + mass_pech * stoim_pech + mass_apple * stoim_apple;
            Console.Write($"Стоимость всей покупки: {all_stoim}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 10. Вывод текста");
            Console.WriteLine();
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("       Труд");
            Console.WriteLine("                Май");
            
            Console.WriteLine();

            Console.WriteLine("Задание 11. Поменять местами 2 значения");
            Console.WriteLine();
            Console.WriteLine("Введите 2 числа: ");
            string firs = Console.ReadLine();
            string secon = Console.ReadLine();
            Console.WriteLine(secon);
            Console.WriteLine(firs);
            
            Console.WriteLine();

            Console.WriteLine("Задание 12. Периметр и площадь фигур");
            Console.WriteLine();
            Console.Write("Введите название фигуры (треугольник, прямоугольник, круг):");
            string fig = Console.ReadLine();
            if (fig == "треугольник")
            {
                Console.WriteLine("площадь или периметр?");
                string or = Console.ReadLine();
                if (or == "площадь")
                {
                    Console.Write("Введите основание: ");
                    double osn_tr = float.Parse(Console.ReadLine());
                    Console.Write("Введите высоту: ");
                    double height_tr = float.Parse(Console.ReadLine());
                    double plosch_tr = 0.5 * osn_tr * height_tr;
                    Console.Write($"Площадь треугольника равна: {plosch_tr}");
                }
                if (or == "периметр")
                {
                    Console.Write("Введите 1 сторону: ");
                    double stor1_tr = float.Parse(Console.ReadLine());
                    Console.Write("Введите 2 сторону: ");
                    double stor2_tr = float.Parse(Console.ReadLine());
                    Console.Write("Введите 3 сторону: ");
                    double stor3_tr = float.Parse(Console.ReadLine());
                    double per_tr = stor1_tr + stor2_tr + stor3_tr;
                    Console.WriteLine($"Периметр треугольника равен: {per_tr}");
                }
            }
            if (fig == "прямоугольник")
            {
                Console.WriteLine("площадь или периметр?");
                string or1 = Console.ReadLine();
                if (or1 == "площадь")
                {
                    Console.Write("Введите первую сторону: ");
                    double stor1_pr = float.Parse(Console.ReadLine());
                    Console.Write("Введите вторую сторону: ");
                    double stor2_pr = float.Parse(Console.ReadLine());
                    double plosch_pr = stor1_pr * stor2_pr;
                    Console.WriteLine($"Площадь прямоугольника равна: {plosch_pr}");
                }
                if (or1 == "периметр")
                {
                    Console.Write("Введите первую сторону: ");
                    double stor1_pr = float.Parse(Console.ReadLine());
                    Console.Write("Введите вторую сторону: ");
                    double stor2_pr = float.Parse(Console.ReadLine());
                    double per_pr = 2 * (stor1_pr + stor2_pr);
                    Console.WriteLine($"Периметр прямоугольника равен: {per_pr}");
                }
            }
            if (fig == "круг")
            {
                Console.WriteLine("площадь или периметр?");
                string or2 = Console.ReadLine();
                if (or2 == "площадь")
                {
                    Console.Write("Введите радиус: ");
                    double radius = float.Parse(Console.ReadLine());
                    double plosch_kr = 3.14 * radius * radius;
                    Console.WriteLine($"Площадь круга равна: {plosch_kr}");
                }
                if (or2 == "периметр")
                {
                    Console.Write("Введите радиус: ");
                    double radius = float.Parse(Console.ReadLine());
                    double per_kr = 2 * 3.14 * radius;
                    Console.WriteLine($"Периметр круга равен: {per_kr}");
                }
            }
            
            Console.WriteLine();

            Console.WriteLine("Задание 13. Вывод числа, введенного с клавиатуры");
            Console.WriteLine();
            Console.WriteLine("Вы ввели число:");
            string chislo = Console.ReadLine();
            Console.WriteLine($"Ваше число: {chislo}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 14. Вывод текста");
            Console.WriteLine();
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
            
            Console.WriteLine();

            Console.WriteLine("Задание 15. Вывод рандомных чисел");
            Console.WriteLine();
            Random rnd = new Random();
            int value = rnd.Next();
            int value1 = rnd.Next();
            int value2 = rnd.Next();
            int value3 = rnd.Next();
            Console.WriteLine(value);
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            
            Console.WriteLine();

            Console.WriteLine("Задание 16. Корни квадратного уравнения");
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
                double x1 = -b / (2 * a);
                Console.WriteLine($"{x1}");
            }
            if (discr < 0)
            {
                Console.WriteLine("Нет корней!");
            }
            
            Console.WriteLine();

            Console.WriteLine("Задание 17. Среднее арифметическое и геометрическое");
            Console.WriteLine();
            Console.WriteLine("Введите 2 целых числа: ");
            int f_ch = int.Parse(Console.ReadLine());
            int s_ch = int.Parse(Console.ReadLine());   
            double sr_ar = (f_ch + s_ch) / 2;
            Console.WriteLine($"Среднее арифметическое: {sr_ar}");
            double sr_geom = Math.Sqrt(f_ch * s_ch);
            Console.WriteLine($"Среднее геометрическое: {sr_geom}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 18. Расстояние между двумя точками на плоскости");
            Console.WriteLine();
            Console.Write("Введите координату х1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату х2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату у2: ");
            double y2 = double.Parse(Console.ReadLine());
            double rasst = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2-y1)*(y2 - y1));
            Console.WriteLine($"Расстояние между точками: {rasst}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 19. Обмен значениями переменных");
            Console.WriteLine();
            Console.Write("Введите число а: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите число с: ");
            double c = double.Parse(Console.ReadLine());
            double xep = a;
            a = b;
            b = c;
            c = xep;
            Console.WriteLine($"Перестановка 1: {a} {b} {c}");
            double xep2;
            Console.WriteLine();
            Console.Write("Введите число а: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("Введите число с: ");
            double c2 = double.Parse(Console.ReadLine());
            xep2 = a2;
            a2 = c2;
            c2 = b2;
            b2 = xep2;
            Console.WriteLine($"Перестановка 2: {a2} {b2} {c2}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 20. Часы");
            Console.WriteLine();
            Console.Write("Введите число секунд: ");
            int sec = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько полных часов прошло с начала суток?");
            int full_hour = sec / 3600;
            Console.WriteLine(full_hour);
            Console.WriteLine("Сколько полных минут прошло с начала нового часа?");
            int full_min = (sec % 3600) / 60;
            Console.WriteLine(full_min);
            Console.WriteLine("Сколько полных секунд прошло с начала очередной минуты?");
            int full_sec = sec % 60;
            Console.WriteLine(full_sec);
            
            Console.WriteLine();

            Console.WriteLine("Задание 21. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?");
            Console.WriteLine();
            Console.Write("Ответ: ");
            Console.WriteLine(543 / 130);
            
            Console.WriteLine();

            Console.WriteLine("Задание 22. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.");
            Console.WriteLine();
            Console.Write("Введите трехзначное число: ");
            int trexznach = int.Parse(Console.ReadLine());
            int itog_ch = (trexznach % 10) * 100 + (trexznach / 10) % 100;
            Console.Write("Измененное число: ");
            Console.WriteLine(itog_ch);
            
            Console.WriteLine();

            Console.WriteLine("Задание 23. Найти число сотен и тысяч в числе");
            Console.WriteLine();
            Console.Write("Введите число >999: ");
            int big_ch = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число сотен: {big_ch/100}");
            Console.WriteLine($"Число тысяч: {big_ch/1000}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 24. Операции с 4значным числом");
            Console.WriteLine();
            Console.Write("Введите 4значное число: ");
            int chislo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Справа налево: {(chislo % 10) * 1000 + ((chislo / 10) % 10) * 100 + ((chislo / 100) % 10) * 10 + (chislo / 1000) % 10}");
            Console.WriteLine($"Число, образуемое при перестановке первой и второй, третьей и четвертой цифр: {((chislo / 100) % 10) * 1000 + ((chislo/1000) % 10) * 100 + (chislo%10) * 10 + (chislo/10) % 10}");
            Console.WriteLine($"Число, образуемое при перестановке второй и третьей цифр заданного числа: {((chislo / 1000) % 10) * 1000 + ((chislo / 10) % 10) * 100 + ((chislo / 100) % 10) * 10 + chislo % 10}");
            Console.WriteLine($"Число, образуемое при перестановке двух первых и двух последних цифр заданного числа: {(chislo % 100) * 100 + (chislo / 100) % 100}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 25. Найти число х");
            Console.WriteLine();
            Console.Write("Введите число 100 <= n <= 999 и при этом число десятков в n не равно нулю: ");
            int ch_n = int.Parse(Console.ReadLine());
            int ch_x = (ch_n % 100) * 10 + (ch_n / 100) % 10;
            Console.WriteLine($"Число х: {ch_x}");
            
            Console.WriteLine();
            
            Console.WriteLine("Задание 26. Угол часовой стрелки");
            Console.WriteLine();
            Console.Write("Введите число часов: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Введите число минут: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Введите число секунд: ");
            int seconds = int.Parse(Console.ReadLine());
            int gr_hours = hours * 30 + minutes / 12 * 6;
            Console.Write($"Угол часовой стрелки равен: {gr_hours} градусов");
            
            Console.WriteLine();

            Console.WriteLine("Задание 28. Меньшее по модулю из трех");
            Console.WriteLine();
            Console.WriteLine("Введите 3 числа: ");
            double fir_ch = double.Parse(Console.ReadLine());
            double sec_ch = double.Parse(Console.ReadLine());
            double thir_ch = double.Parse(Console.ReadLine());
            fir_ch = Math.Abs(fir_ch);
            sec_ch = Math.Abs(sec_ch);
            thir_ch = Math.Abs(thir_ch);
            if (fir_ch <= sec_ch && fir_ch <= thir_ch)
            {
                Console.WriteLine($"Минимальное по модулю: {fir_ch}");
            }
            if (sec_ch <= thir_ch && sec_ch <= fir_ch)
            {
                Console.WriteLine($"Минимальное по модулю: {sec_ch}");
            }
            if (thir_ch <= fir_ch && thir_ch <= sec_ch)
            {
                Console.WriteLine($"Минимальное по модулю: {thir_ch}");
            }
            
            Console.WriteLine();

            Console.WriteLine("Задание 29. Сумма большего и меньшего из трех");
            Console.WriteLine();
            Console.WriteLine("Введите 3 числа: ");
            double fi = double.Parse(Console.ReadLine());
            double se = double.Parse(Console.ReadLine());
            double th = double.Parse(Console.ReadLine());
            double minim = Math.Min(Math.Min(fi, se), th);
            double maxim = Math.Max(Math.Max(fi, se), th);
            double summa = minim + maxim;
            Console.WriteLine($"Сумма: {summa}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 30. Количество делителей натурального числа");
            Console.WriteLine();
            Console.Write("Введите число: ");
            int nat_ch = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i=1; i * i <= nat_ch; i++)
            {
                if (nat_ch % i == 0)
                {
                    if (i * i != nat_ch)
                    {
                        count+=2;
                    }
                    if (i * i == nat_ch)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Количество делителей: {count}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 31. Кубическое уравнение");
            Console.WriteLine();
            Console.Write("Введите коэффициент А: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент В: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент С: ");
            double C = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент D: ");
            double D = double.Parse(Console.ReadLine());
            for (int X = -100; X <= 100; X++)
            {
                if ((A * X * X * X + B * X * X + C * X + D) == 0)
                {
                    Console.WriteLine("Корни уравнения: ");
                    Console.WriteLine($"X1 = {X}");
                    Console.WriteLine($"X2 = {X}");
                    Console.WriteLine($"X3 = {X}");
                }
            }
            
            Console.WriteLine();

            Console.WriteLine("Задание 32. Арифметическая пргрессия");
            Console.WriteLine();
            Console.Write("Введите первый элемент арифметической прогрессии: ");
            int el1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второй элемент арифметической прогрессии: ");
            int el2 = int.Parse(Console.ReadLine());
            Console.Write("Введите номер элемента, значение которого хотите найти: ");
            int num_el = int.Parse(Console.ReadLine());
            int eln = el1 + (num_el - 1) * (el2 - el1);
            Console.WriteLine($"a{num_el} = {eln}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 33. Дадут ли кредит?");
            Console.WriteLine();
            Console.WriteLine("Вы пенсионер? (я пенсионер | я не пенсионер)");
            string pens = Console.ReadLine();
            Console.WriteLine("Вы студент? (я студент | я не студент)");
            string stud = Console.ReadLine();
            Console.WriteLine("Трудоустроены ли вы? (я трудоустроен | я не трудоустроен)");
            string trud = Console.ReadLine();
            if ((pens == "я пенсионер" || stud == "я студент") && trud == "я не трудоустроен")
            {
                Console.WriteLine("Кредит получен");
            }
            if ((pens == "я пенсионер" || stud == "я студент") && trud == "я трудоустроен")
            {
                Console.WriteLine("кредит не получен");
            }
            if (pens == "я пенсионер" && stud == "я студент")
            {
                Console.WriteLine("Кредит не получен");
            }
            
            Console.WriteLine();

            Console.WriteLine("Задание 34. Имя");
            Console.WriteLine();
            Console.WriteLine("Как тебя зовут?");
            string names = Console.ReadLine();
            Console.WriteLine($"Повтор имени: {names}");
            Console.WriteLine("Как тебя зовут?");
            string names2 = Console.ReadLine();
            Console.WriteLine($"Привет, {names2}");
        }
    }
}
