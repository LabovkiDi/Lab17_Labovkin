using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_Labovkin
{
    class Program
    {
        // обобщенный класс СЧЕТ В БАНКЕ
        class AccountBank<T>
        {
            // приватные поля класса
            private T Id { get; set; }     // универсальный параметр
            private int Sum { get; set; }        // баланс
            private string Surname { get; set; } // фамилия
            private string Name { get; set; }    // имя
            private string Midname { get; set; } // отчество

            // запись данных в поля класса
            public void setInfo(T id, int sum, string surname, string name, string midname)
            {
                // присвоение полям класса значений из параметров полученных методом
                Id = id;
                Sum = sum;
                Surname = surname;
                Name = name;
                Midname = midname;
            }

            // вывод информации о счете
            public void getInfo()
            {
                Console.WriteLine($"№ {Id}");
                Console.WriteLine($"{ Surname} {Name} {Midname}");
                Console.WriteLine($"Баланс: {Sum}$");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // создание экземпляров класса с различными типами
            AccountBank<int> acc1 = new AccountBank<int>();
            AccountBank<string> acc2 = new AccountBank<string>();
            AccountBank<int> acc3 = new AccountBank<int>();
            // заполнение экземпляров класса значениями
            acc1.setInfo(57, 78000, "Иванов", "Алексей", "Николаевич");
            acc2.setInfo("ГЛ09", 90000, "Петров", "Иван", "Михайлович");
            acc3.setInfo(102, 75000, "Коньков", "Сергей", "Федорович");
            // вывод информации о счетах клиентов
            acc1.getInfo();
            acc2.getInfo();
            acc3.getInfo();

            Console.ReadKey();// пауза окна консоли
        }
    }
}
