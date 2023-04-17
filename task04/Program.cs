// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых 
//расположен наименьший элемент массива.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7*/

int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int n = Num("количество строк");
int m = Num("количество столбцов");

int[,] matrix = new int[n, m];

void FillArray(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(1,100);
        }
    }
}

void PrintArray(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] MinNum(int [,] matrix)
{
    int MinNum = matrix[0,0];
    int imin = 0;
    int jmin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < MinNum) 
            {
                MinNum=matrix[i,j];
                imin = i;
                jmin = j;
            }
        }
    }
    System.Console.WriteLine($"минимальный элемент массива {MinNum} находится в {imin} строке, {jmin} столбце");
    int [,] array1= ModifyArray(matrix, imin, jmin);
    return array1;
}

int [,] ModifyArray(int[,] array, int imin, int jmin)
{
    int [,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    int x =0;
    int y =0;
    for (int i = 0; i < newArray.GetLength(0); i++)  
    {
        if (i==imin)
        {
            x=1;
        }
        for (int j = 0; j < newArray.GetLength(1); j++)  
        {
            if (j == jmin) 
            {
                y =1;
            }
            newArray[i,j]=array[i+x,j+y];
        }
        y=0;
    }
    return newArray;
}



FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
int[,] NewMatrix = MinNum(matrix);
PrintArray(NewMatrix);