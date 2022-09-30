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
    struct Student
    {
        public string name;
        public string surname;
        public int ident;
        public string dat_r;
        public string kat_alco;
        public double v_alko;
        public Student(string Name, string Surname, int Ident, string Dat_r, string Kat_alco, double V_alko)
        {
            this.name = Name;
            this.surname = Surname;
            this.ident = Ident;
            this.dat_r = Dat_r;
            this.kat_alco = Kat_alco;
            this.v_alko = V_alko;
        }
        public double got_v_alko()
        {
            return v_alko;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Идентикатор: {ident}, Дата рождения: {dat_r}, Категория алкоголизма: {kat_alco}, Объём выпитого алкоголя: {v_alko}");
        }
    }

    struct User
    {
        public string name;
        public string city;
        public int vozr;
        public int pin;
        public User(string Name, string City, int Vozr, int Pin)
        {
            this.name = Name;
            this.city = City;
            this.vozr = Vozr;
            this.pin = Pin;
        }
        public void Print2()
        {
            Console.WriteLine($"Имя: {name}, Город: {city}, Возраст: {vozr}, Пин: {pin}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 35. Диалог");
            Console.WriteLine();
            Console.WriteLine("Привет, Консоль!");
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");
            Console.WriteLine("Знаешь ли ты что-то о тайной комнате?");
            Console.WriteLine("Да");
            Console.WriteLine("А можешь рассказать?");
            Console.Write("Нет");
            Thread.Sleep(5000);
            Console.WriteLine(", но могу показать");
            Random r = new Random();
            Console.BackgroundColor = (ConsoleColor)r.Next(0, 16);

            Console.WriteLine();

            Console.WriteLine("Задание 1. Структура студента");
            Console.WriteLine();
            Student stud1 = new Student("Данил", "Тютин", 1, "25.10.2000", "с", 1.1);
            stud1.Print();
            Student stud2 = new Student("Айгуль", "Закирова", 2, "14.05.1999", "b", 0.8);
            stud2.Print();
            Student stud3 = new Student("Артем", "Иванов", 3, "20.05.2005", "a", 0.2);
            stud3.Print();
            Student stud4 = new Student("Анжела", "Гитдинова", 4, "15.03.2003", "c", 1.2);
            stud4.Print();
            Student stud5 = new Student("Раиль", "Гафуров", 5, "24.05.2002", "d", 0.0);
            stud5.Print();
            double vse = stud1.got_v_alko() + stud2.got_v_alko() + stud3.got_v_alko() + stud4.got_v_alko() + stud5.got_v_alko();
            Console.WriteLine($"Первый студент выпил: {Math.Round((stud1.got_v_alko() / vse) * 100, 1)}%" + "\n" + $"Второй студент выпил: {Math.Round((stud2.got_v_alko() / vse) * 100, 1)}%" + "\n" + $"Третий студент выпил: {Math.Round((stud3.got_v_alko() / vse) * 100, 1)}%" + "\n" + $"Четвёртый студент выпил: {Math.Round((stud4.got_v_alko() / vse) * 100, 1)}%" + "\n" + $"Пятый студент выпил: {Math.Round((stud5.got_v_alko() / vse) * 100, 1)}%" + "\n" + $"Общий объём алкоголя: {vse} литров");

            Console.WriteLine();

            Console.WriteLine("Задание 2. Типы данных");
            Console.WriteLine();
            Console.WriteLine($"sbyte: {sbyte.MinValue} ... {sbyte.MaxValue}" + "\n" +
            $"byte: {byte.MinValue} ... {byte.MaxValue}" + "\n" +
            $"short: {short.MinValue} ... {short.MaxValue}" + "\n" +
            $"ushort: {ushort.MinValue} ... {ushort.MaxValue}" + "\n" +
            $"int: {int.MinValue} ... {int.MaxValue}" + "\n" +
            $"uint: {uint.MinValue} ... {uint.MaxValue}" + "\n" +
            $"long: {long.MinValue} ... {long.MaxValue}" + "\n" +
            $"ulong: {ulong.MinValue} ... {ulong.MaxValue}" + "\n" +
            $"char: U+000 ... U+ffff" + "\n" +
            $"float: {float.MinValue} ... {float.MaxValue}" + "\n" +
            $"double: {double.MinValue} ... {double.MaxValue}" + "\n" +
            "bool: true ... false" + "\n" +
            $"decimal: {decimal.MinValue} ... {decimal.MaxValue}" + "\n" +
            "string: Ограничено только системной памятью" + "\n" +
            "object: Всё");

            Console.WriteLine();

            Console.WriteLine("Задание 3. Все в одну переменную");
            Console.WriteLine();
            User user = new User();
            Console.WriteLine("Введите своё имя: ");
            user.name = Console.ReadLine();
            Console.WriteLine("Введите свой город: ");
            user.city = Console.ReadLine();
            Console.WriteLine("Введите свой возраст: ");
            user.vozr = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой пин: ");
            user.pin = int.Parse(Console.ReadLine());
            user.Print2();

            Console.WriteLine();

            Console.WriteLine("Задание 4. Инициалы");
            Console.WriteLine();
            string[] Name = Console.ReadLine().Split(' ');
            Console.WriteLine($"{Name[0][0].ToString().ToUpper()}.{Name[1][0].ToString().ToUpper()}");

            Console.WriteLine();
            
            Console.WriteLine("Задание 5. Экономия кроет расходы");
            Console.WriteLine();
            Console.Write("Введите стандартную цену: ");
            int normPrice = int.Parse(Console.ReadLine());
            Console.Write("Введите скидку в %: ");
            double sellPrice = 0.01 * int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость отпуска: ");
            int holidayPrice = int.Parse(Console.ReadLine());
            double econ_on_but = normPrice * sellPrice;
            double kol_but = holidayPrice / econ_on_but;
            Console.WriteLine($"Бутылок виски нужно купить: {Math.Floor(kol_but)}");

            Console.WriteLine();
            
            Console.WriteLine("Задание 6. Перевод единиц скорости");
            Console.WriteLine();
            Console.Write("Введите скорость в км/ч: ");
            double v_tar = double.Parse(Console.ReadLine());
            double per_v = Math.Floor(v_tar * 100000 / 3600);
            Console.WriteLine($"Скорость в см/с: {per_v}");
            
            Console.WriteLine();

            Console.WriteLine("Задание 1. Голова в форточке");
            Console.WriteLine();
            Console.Write("Введите длину форточки (см): ");
            double dlina = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину форточки (см): ");
            double shirina = double.Parse(Console.ReadLine());
            Console.Write("Введите диаметр головы (см): ");
            double diametr = double.Parse(Console.ReadLine());
            if (dlina-2 >= diametr && shirina-2 >= diametr)
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
            for (int i=0; i<=10; i++)
            {
                Console.WriteLine($"{i} * {n} = {i*n}");   
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
            for (int i=1; i <= nat_ch; i++)
            {
                Console.Write($"{i} овца... ");
            }
        }   
    }
}
