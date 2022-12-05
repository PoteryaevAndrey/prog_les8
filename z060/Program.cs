/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int[,,] CreateRandom3DArray(int str, int rows, int columns, int minValue, int maxValue)
{
    int[,,] newArray = new int[str, rows, columns];

    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }

    return newArray;
}

void Print3DArrayWithIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}  ({i}, {j}, {k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] newArray = CreateRandom3DArray(2, 2, 2, 10, 99);
Print3DArrayWithIndex(newArray);