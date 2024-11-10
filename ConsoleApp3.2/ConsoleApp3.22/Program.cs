using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть кількість рядків масиву:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпців масиву:");
            int m = int.Parse(Console.ReadLine());

            double[,] a = new double[n, m];
            Random rand = new Random();
            double min = -12.3;
            double max = 126.3;

            Console.WriteLine("Початковий масив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Math.Round(rand.NextDouble() * (max - min) + min, 1);
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            double maxColumnSum = double.MinValue;
            int maxColumnIndex = -1;

            Console.WriteLine("\nСуми елементів по стовпцях:");
            for (int j = 0; j < m; j++)
            {
                double columnSum = 0;
                for (int i = 0; i < n; i++)
                {
                    columnSum += a[i, j];
                }
                Console.WriteLine($"Сума стовпця {j + 1}: {columnSum}");

                if (columnSum > maxColumnSum)
                {
                    maxColumnSum = columnSum;
                    maxColumnIndex = j;
                }
            }

            Console.WriteLine($"\nНайбільша сума стовпця: {maxColumnSum} (Стовпець {maxColumnIndex + 1})");

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double t = a[i, j];
                    a[i, j] = a[n - i - 1, j];
                    a[n - i - 1, j] = t;
                }
            }

            Console.WriteLine("\nМасив після обміну рядків:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Натисніть будь-яку клавішу, щоб закрити програму...");
            Console.ReadKey();
        }
    }
}
