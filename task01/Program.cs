//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
            matrix[i,j]=new Random().Next(-100,100);
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

void NewArray(int [,]matrix)
{
    int temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1, j];
        matrix[matrix.GetLength(0) -1, j] = temp;
    }
}

FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
NewArray(matrix);
PrintArray(matrix);