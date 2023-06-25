// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hight = 4;
            int width = 4;
            int[,] array = new int[hight, width];

            UpdateArray(ref array, width, hight);


        }
        static void UpdateArray(ref int[,] array, int width, int hight)
        {
            int valueH = hight / 2;
            int valueW = width / 2;
            int dx = 0;
            int dy = 0;
            int value = 1;
            array[valueH, valueW] = value;
            value++;

            for (int i = value; i < hight * width + 1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    switch (j)
                    {
                        case 0: // влево
                            dx = -1;
                            dy = 0;
                            break;
                        case 1:  //вниз
                            dx = 0;
                            dy = 1;
                            break;
                        case 2: //вправо
                            dx = 1;
                            dy = 0;
                            break;
                        case 3: //вверх
                            dx = 0;
                            dy = -1;
                            break;
                        case 4:
                            j = 0;
                            break;
                    }

                    if (valueH + dy >= 0 && valueH + dy < hight && valueW + dx >= 0 && valueW + dx < width)
                    {
                        if (array[valueH + dy, valueW + dx] == 0)
                        {
                            if (value == 2)
                            {
                                array[valueH + dy, valueW + dx] = value;
                                value++;
                                valueH += dy;
                                valueW += dx;
                                break;
                            }
                            else if (j == 0)
                            {
                                if (valueH + 1 < hight && valueW < width)
                                {
                                    if (array[valueH + 1, valueW] == 0)
                                        continue;
                                    else
                                    {
                                        array[valueH + dy, valueW + dx] = value;
                                        value++;
                                        valueH += dy;
                                        valueW += dx;
                                        break;
                                    }
                                }
                            }

                            else if (j == 1)
                            {
                                if (valueW + 1 < width)
                                {
                                    if (array[valueH, valueW + 1] == 0)
                                        continue;
                                    else
                                    {
                                        array[valueH + dy, valueW + dx] = value;
                                        value++;
                                        valueH += dy;
                                        valueW += dx;
                                        break;
                                    }
                                }
                            }
                            else if (j == 2)
                            {
                                if (valueH - 1 >= 0)
                                {
                                    if (array[valueH - 1, valueW] == 0)
                                        continue;
                                    else
                                    {
                                        array[valueH + dy, valueW + dx] = value;
                                        value++;
                                        valueH += dy;
                                        valueW += dx;
                                        break;
                                    }
                                }
                            }
                            else if (j == 3)
                            {
                                if (valueH >= 0 && valueW - 1 >= 0)
                                {
                                    if (array[valueH, valueW - 1] == 0)
                                        continue;
                                    else
                                    {
                                        array[valueH + dy, valueW + dx] = value;
                                        value++;
                                        valueH += dy;
                                        valueW += dx;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                Console.Clear();
                Render(ref array, hight, width);
                Thread.Sleep(10);
            }
        }
        static void Render(ref int[,] array, int hight, int width)
        {
            Console.WriteLine();
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    Console.Write("{0, 4}", array[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }


}


