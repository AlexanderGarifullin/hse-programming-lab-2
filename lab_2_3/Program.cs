using System;
namespace lab_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string buf;
            double x, xPower = 1, s = 0;
            uint n, i = 1;
            bool isCorrect;
            #region ввод исходных данных
            do
            {
                Console.WriteLine("Введите целое неотрицательное число n");
                buf = Console.ReadLine();
                isCorrect = uint.TryParse(buf, out n);
                if (!isCorrect) Console.WriteLine("Не верно введены данные");
            } while (!isCorrect);

            do
            {
                Console.WriteLine("Введите вещественное число x");
                buf = Console.ReadLine();
                isCorrect = Double.TryParse(buf, out x);
                if (!isCorrect) Console.WriteLine("Не верно введены данные");
            } while (!isCorrect);
            #endregion;
            if (n != 0)
            {
                while (i <= n)
                {

                    xPower *= x;
                    s += Math.Sin(xPower * Math.PI / 180);
                    ++i;
                }
            }
            else if (n == 0)
                s = Math.Sin(Math.PI / 180);
            Console.WriteLine($"S = sin X + sin X^2 + ... + sin X^n = {s}");
        }
    }
}
