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
            double s = 0;
            for (int k = 1; k <= n; k++)
            {
                s += (3 * k) * (3 * k + (2 - k));
            }
            Console.WriteLine($"Ответ: {s}");
        }
    }
}