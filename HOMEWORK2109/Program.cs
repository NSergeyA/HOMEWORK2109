using System.Text.RegularExpressions;
using System.Threading;
using System;

namespace HOMEWORK2109
{
    internal class Program
    {
        struct Person
        {
            public string name;
            public int age;
            public string city;
            public long PIN;
            public void Print()
            {
                Console.WriteLine($"ИМЯ - {name}, ГОРОД ПРОЖИВАНИЯ - {city}, ВОЗРАСТ - {age}, ПИН-КОД - {PIN}");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");

            Console.WriteLine($"Минимальное значение типа byte: {Byte.MinValue} | Максимальное: {Byte.MaxValue}");
            Console.WriteLine($"Минимальное значение типа sbyte: {SByte.MinValue} | Максимальное: {SByte.MaxValue}");
            Console.WriteLine($"Минимальное значение типа short: {short.MinValue} | Максимальное: {short.MaxValue}");
            Console.WriteLine($"Минимальное значение типа ushort: {ushort.MinValue} | Максимальное: {ushort.MaxValue}");
            Console.WriteLine($"Минимальное значение типа int: {int.MinValue} | Максимальное: {int.MaxValue}");
            Console.WriteLine($"Минимальное значение типа uint: {uint.MinValue} | Максимальное: {uint.MaxValue}");
            Console.WriteLine($"Минимальное значение типа long: {long.MinValue} | Максимальное: {long.MaxValue}");
            Console.WriteLine($"Минимальное значение типа ulong: {ulong.MinValue} | Максимальное: {ulong.MaxValue}");
            Console.WriteLine($"Минимальное значение типа decimal: {decimal.MinValue} | Максимальное: {decimal.MaxValue}");
            Console.WriteLine($"Минимальное значение типа float: {float.MinValue} | Максимальное: {float.MaxValue}");
            Console.WriteLine($"Минимальное значение типа double: {double.MinValue} | Максимальное: {double.MaxValue}");
            Console.WriteLine("Минимальное значение типа string: N/A | Максимальное: N/A ");
            Console.WriteLine("Минимальное значение типа bool: N/A | Максимальное: N/A");
            Console.WriteLine("Минимальное значение типа object: N/A | Максимальное: N/A");
            Console.WriteLine("Минимальное значение типа dynamic: N/A | Максимальное: N/A");
            Console.WriteLine($"Минимальное значение типа char: {char.MinValue} | Максимальное: {char.MaxValue}");
            Console.ReadKey();

            Console.WriteLine("Задание 2:");
            Console.Write("Введите ваше имя - ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш город проживания - ");
            string city = Console.ReadLine();
            Console.Write("Введите ваш возраст - ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш пин-код - ");
            long PIN = Convert.ToInt64(Console.ReadLine());
            Person person = new Person();
            person.name = name;
            person.age = age;
            person.city = city;
            person.PIN = PIN;
            person.Print();
            Console.ReadKey();

            Console.WriteLine("Задание 3:");
            Console.Write("Введите строку:");
            string strk = Console.ReadLine();
            string new_strk = string.Empty;
            foreach (char a in strk)
            {
                new_strk += Char.IsUpper(a) ? Char.ToLower(a) : Char.ToUpper(a);
            }
            Console.WriteLine($"Строка с учетом изменений: {new_strk}");
            Console.ReadKey();


            Console.WriteLine("Задание 4: ");
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.Write("Введите подстроку");
            string sub_stroka = Console.ReadLine();
            int kpodstrok = new Regex(sub_stroka).Matches(stroka).Count;
            Console.WriteLine($"Количество вхождений подстроки - {kpodstrok}");
            Console.ReadKey();

            Console.WriteLine("Задание 5:");
            Console.Write("Введите цену виски - ");
            double whiski_price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скидку на виски в процентах - ");
            double sale_percent = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость отпуска - ");
            double holidayprice = Convert.ToDouble(Console.ReadLine());
            double whiski_sale = whiski_price * (sale_percent / 100);
            double numberofbattles = holidayprice / whiski_sale;
            Console.WriteLine($"Количество необходимых бутылок для отпуска - {numberofbattles}");
            Console.ReadKey();


            Console.WriteLine("Задание 6:");
            Console.WriteLine("Поздоровайтесь с 'Консолью':");
            Console.Write("Пользователь: ");
            Console.ReadLine();
            Console.WriteLine("Консоль: Как зовут Пользователя?");
            Console.Write($"Пользователь: ");
            string pname = Console.ReadLine();
            Console.WriteLine($"Консоль: Здравствуйте, {pname}");
            Console.Write("Пользователь: ");
            Console.ReadLine();
            Console.WriteLine("Консоль: Да");
            Console.Write("Пользовать: ");
            Console.ReadLine();
            Console.WriteLine("Консоль: Нет...");
            Thread.Sleep(5000);
            Console.WriteLine("Консоль:Но могу показать");
            Thread.Sleep(1000);
            Random random = new Random();
            int random_number = random.Next();
            if (random_number % 4 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Blue;

            }
            if (random_number % 4 == 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;

            }
            if (random_number % 4 == 2)
            {
                Console.BackgroundColor = ConsoleColor.Green;

            }
            if (random_number % 4 == 3)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            Thread.Sleep(3000);
            Console.Clear();
            Console.ReadKey();


















        }
    }
}
