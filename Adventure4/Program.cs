// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)








int L = InputNumbers("Введите первую меру:  ");
int H = InputNumbers("Введите вторую меру:  ");
int Z = InputNumbers("Введите третью меру:  ");

int[,,] array = new int[L, H, Z];
System.Console.WriteLine("Вывод массива ");

CreateArray(array);
PrintArray(array);


static int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());

    return output;
}



void CreateArray(int[,,] array)
{


    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {

                array[x, y, z] = temp[count];


                Console.Write(string.Join("{0}[{1},{2},{3}] = ", array, x, y, z));

                count++;
            }
        }
    }
}


void PrintArray(int[,,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(0); b++)
        {
            for (int c = 0; c < array.GetLength(1); c++)
            {
                Console.Write(array[a, b, c] + " ");
            }
            Console.WriteLine();
        }
    }
}



