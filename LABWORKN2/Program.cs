using System;

namespace LABWORKN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1:");
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            Console.ReadKey();



            Console.WriteLine("Упражнение 2.2:");
            Console.Write("Введите число делитель - ");
            double frst_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите делимое число - ");
            double scnd_num = Convert.ToInt32(Console.ReadLine());
            double rezult = frst_num / scnd_num;
            if (scnd_num == 0)
            {
                Console.WriteLine("Нельзя делить на ноль!");
            }
            Console.WriteLine($"Ответ - {rezult}");
            Console.ReadKey();


            Console.WriteLine("Домашняя работа 2.1: ");
            Console.Write("Введите букву - ");
            char word = Console.ReadKey().KeyChar;
            char nxt_word = (char)(((int)word) + 1);
            if (word == 'z' || word == 'я')
            {
                Console.WriteLine("\nСледующая буква - a");
            }
            else
            {
                Console.WriteLine($"\nСледующая буква - {nxt_word}");
            }



            Console.WriteLine("Домашняя работа 2.2: ");
            Console.WriteLine("Квадратное уравнение - (ax^2 + bx + c = 0)");
            Console.Write("Введите коэффициент a - ");
            double ka = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b - ");
            double kb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c - ");
            double kc = Convert.ToDouble(Console.ReadLine());
            double D = (kb * kb) - (4 * ka * kc);
            double frst_x = (-1 * kb - Math.Sqrt(D)) / (2 * ka);
            double scnd_x = (-1 * kb + Math.Sqrt(D)) / (2 * ka);
            if (D < 0)
            {
                Console.WriteLine("Коэффициент меньше нуля");
            }
            else
            {
                Console.WriteLine($"Корни уравнения:  x1 = {frst_x}, x2 = {scnd_x}");
            }
            Console.ReadKey();






        }
    }
}
