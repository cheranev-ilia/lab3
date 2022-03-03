using System;
using RomanNum;

namespace Lab_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ushort[] num = { 5, 271, 3140, 240, 526, 85,769 };
            RomanNumber[] rn = { new RomanNumber(num[0]), new RomanNumber(num[1]), new RomanNumber(num[2]), new RomanNumber(num[3]), new RomanNumber(num[4]),new RomanNumber(num[5]), new RomanNumber(num[6])};

            Console.WriteLine("Массив:");
            for (int i = 0; i < 7; i++)
                Console.Write($"{num[i]}\t");
            Console.WriteLine("\n");
            for (int i = 0; i < 7; i++)
                Console.Write($"{rn[i].ToString()}\t");

            Console.WriteLine("\n\nОтсортированный массив:");
            Array.Sort(rn);
            Array.Sort(num);
            for (int i = 0; i < 7; i++)
                Console.Write($"{num[i]}\t");
            Console.WriteLine();
            for (int i = 0; i < 7; i++)
                Console.Write($"{rn[i].ToString()}\t");

            Console.WriteLine($"\n\n{num[0]} + {num[1]} = {num[0] + num[1]}");
            Console.WriteLine($"{rn[0].ToString()} + {rn[1].ToString()} = {(rn[0] + rn[1]).ToString()}");

            Console.WriteLine($"\n{num[1]} - {num[0]} = {num[1] - num[0]}");
            Console.WriteLine($"{rn[1].ToString()} - {rn[0].ToString()} = {(rn[1] - rn[0]).ToString()}");

            Console.WriteLine($"\n{num[0]} * {num[1]} = {num[0] * num[1]}");
            Console.WriteLine($"{rn[0].ToString()} * {rn[1].ToString()} = {(rn[1] * rn[0]).ToString()}");

            Console.WriteLine($"\n{num[1]} / {num[0]} = {num[1] / num[0]}");
            Console.WriteLine($"{rn[1].ToString()} / {rn[0].ToString()} = {(rn[1] / rn[0]).ToString()}");
        }
    }
}