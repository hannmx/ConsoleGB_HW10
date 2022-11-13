using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGB_HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num = rand.Next(100, 1000);
            int result = 0;
            void Number()
            {
                Console.WriteLine("Случайное трёхзначное число: " + num);
                result = (num - (num / 100) * 100 - num % 10) / 10;
                Console.WriteLine($"Вторая цифра числа {num}: {result}");
            }
            Number();
        }
    }
}
