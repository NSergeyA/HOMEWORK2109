using System;

namespace LABWORKN3
{
    internal class Program
    {
        enum Acc
        {
            current = 250000,
            saving = 2500
        }
        struct Bank
        {
            public long acc_number;
            public string acc_type;
            public int acc_balance;
            public void Print()
            {
                Console.WriteLine($"Номер счёта - {acc_number} , тип счёта - {acc_type} , баланс на счету - {acc_balance}");
            }

        }
        enum VUZ
        {
            KGU,
            KAI,
            KHTI
        }
        public struct Worker
        {
            public string name;
            public string vuz;
            public void Print()
            {
                Console.WriteLine($"Имя Работника - {name}, ВУЗ - {vuz}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            Acc money = Acc.current;

            Console.WriteLine($"Тип счёта - {money}, Текущий счёт - {(int)money}");
            Console.ReadKey();



            Console.WriteLine("Упражнение 3.2");
            Bank bank_acc = new Bank();
            bank_acc.acc_number = 2200200254676578;
            bank_acc.acc_type = "Сберегательный аккаунт";
            bank_acc.acc_balance = 25000;
            bank_acc.Print();
            Console.ReadKey();



            Console.WriteLine("Домашнее задание 3.1");
            VUZ vuz = (VUZ)2;
            Worker worker = new Worker();
            worker.name = "Сергей";
            worker.vuz = Convert.ToString(vuz);
            worker.Print();
            Console.ReadKey();



        }
    }
}
