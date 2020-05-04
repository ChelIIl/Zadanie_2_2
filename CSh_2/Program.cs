using System;

namespace CSh_2
{
    class Program
    {
        static void Main()
        {
            try
            {
                DateTime d;
                int n;

                Console.Write("Введите дату:");
                d = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Введите кол-во дней:");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Результатирующая дата:" + d.AddDays(-n).ToString("dd.MM.yyyy"));

                Console.ReadKey();
            }

            catch
            {
                Console.WriteLine("Некоректный ввод данных!");
                Console.ReadKey();
            }
        }
    }
}
