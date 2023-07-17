using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            uint countEven = 0;
            string buf;
            bool isCorrect;
            do
            {
                do
                {
                    Console.WriteLine("Введите целое число number");
                    buf = Console.ReadLine();
                    isCorrect = int.TryParse(buf, out number);
                    if (!isCorrect) Console.WriteLine("Не верно введены данные");
                } while (!isCorrect);
                if (number != 0 && number % 2 == 0)
                    countEven++;
            } while (number != 0);
            Console.WriteLine($"Количество четных чисел в последовательности = {countEven}");
        }
    }
}
