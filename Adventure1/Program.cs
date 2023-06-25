// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using System;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            System.Console.WriteLine("Введите длинну массива:   ");
            int colCount = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Введите высоту массива:   ");
            int rowCount = int.Parse(Console.ReadLine()!);
            int[,] arr = GenerateArray(rowCount, colCount);
            Console.WriteLine("Исходный массив");
            PrintArray(arr);
            Console.WriteLine("Сортировка по строкам: ");

            int[] row = new int[colCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                    row[j] = arr[i, j];
                BubbleSort(row);
                Insert(true, i, row, arr);

            }
            PrintArray(arr);
        }
        public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
        {
            for (int k = 0; k < source.Length; k++)
            {
                if (isRow)
                    dest[dim, k] = source[k];
                else
                    dest[k, dim] = source[k];
            }
        }
        public static int[,] GenerateArray(int t, int i)
        {
            int[,] table = new int[t, i];
            Random random = new Random();
            for (int a = 0; a < t; a++)
            {
                for (int b = 0; b < i; b++)
                {
                    table[a, b] = random.Next(0, 9);
                }
            }
            return table;
        }
        public static void PrintArray(int[,] array)
        {
            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    Console.Write(array[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
        static void BubbleSort(int[] inArray)
        {

            Array.Sort(inArray);
            Array.Reverse(inArray);
        }
    }
}