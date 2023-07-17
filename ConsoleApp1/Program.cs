using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            int number, sum = 0; 
            bool isCorrect;        
            do
            {
                Console.WriteLine("Введите длину последовательности");
                isCorrect = uint.TryParse(Console.ReadLine(), out n);
                if (!isCorrect) 
                    Console.WriteLine("Не верно ввели длину последовательности.\n" +
                                      "Длина последовательности может быть лишь больше 0");
                else if (n == 0)
                {
                    isCorrect = false;
                    Console.WriteLine("Не верно ввели длину последовательности.\n" +
                                      "Длина последовательности может быть лишь больше 0");
                }

            } while (!isCorrect);
            for (int i = 1; i <= n; i++)
            {
                do
                {
                    Console.WriteLine("Введите целое число");
                    isCorrect = int.TryParse(Console.ReadLine(), out number);
                    if (!isCorrect)
                        Console.WriteLine("Не верно ввели целое число");
                } while (!isCorrect);
                if (i % 2 == 1)
                    sum += number;
            }
            Console.WriteLine($"Сумма элементов с нечетными номерами = {sum}");
        }
    }
}
