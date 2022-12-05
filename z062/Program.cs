// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            if (array[i, j] < 10) 
            {
                Console.Write($"0{array[i, j]}  "); 
            }
            else
                Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }    
    Console.WriteLine();  
}


int[,] NewArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= newArray.GetLength(0) * newArray.GetLength(1))
    {
        newArray[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < newArray.GetLength(0) - 1)
            j++;
        else if (i < j && i + j >= newArray.GetLength(1) - 1)
            i++;
        else if (i >= j && i + j > newArray.GetLength(0) - 1)
            j--;
        else 
            i--;
    }

    return newArray;
}


int[,] array = NewArray(4, 4);
Print2DArray(array);