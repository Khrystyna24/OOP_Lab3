using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть кількість елементів масиву:");
            int a= int.Parse(Console.ReadLine());
            double[] n = new double[a];
            Random rand = new Random();
            double min = -110.34;
            double max = 110.35;

            Console.WriteLine("Початковий масив:");
            for (int i = 0; i < a; ++i)
            {
                n[i] = Math.Round(rand.NextDouble() * (max - min) + min, 2);

                Console.Write("\t" + n[i]);
            }
            Console.WriteLine();

            double sum = 0;
            Console.WriteLine("Від'ємні елементи з парними індексами:");
            for (int i = 0; i < a; i += 2) 
            {
                if (n[i] < 0)
                {
                    sum += n[i];
                    Console.Write(n[i] + " ");
                }
            }
            Console.WriteLine("\nСума від'ємних елементів масиву з парними індексами = " + sum);


            for (int i = 1; i < a - 1; i += 2) 
            {
                for (int j = i + 2; j < a; j += 2) 
                {
                    if (n[i] < n[j]) 
                    {
                        double t = n[i];
                        n[i] = n[j];
                        n[j] = t;
                    }
                }
            }

            Console.WriteLine("Масив після сортування елементів з непарними індексами за спаданням:");
            foreach (double num in n)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Натисніть будь-яку клавішу, щоб закрити програму...");
            Console.ReadKey();
        }
    }
}
