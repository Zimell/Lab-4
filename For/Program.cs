using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите X = ");
            int n = int.Parse(Console.ReadLine());
            int z = 3;
            int x = 4;
            int answer = 0;
            for (int k = 1; k <= n; k++)
            {
                answer += z * x;
                z = z + 3;
                x = x + 2;
            }
            Console.WriteLine($"Ответ сумма ряда = {answer}");
        }
    }
}
