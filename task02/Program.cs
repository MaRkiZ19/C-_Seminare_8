//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

bool Examination(int n, int m)
{
    if (n == m) return true; // Не допасина, ниже эталон
}



FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();


/*int height = new Random().Next(3,7);
int length = new Random().Next(3,7);

int[,] arr = FillArray(height, length);
PrintArray(arr);
System.Console.WriteLine();
if(arr.GetLength(0) == arr.GetLength(1))
{
    ReverceArray(arr);
    PrintArray(arr);
}
else
{
    System.Console.WriteLine("No way");
}

int[,] FillArray(int height, int length)
{
    int[,] array = new int[height, length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10,11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "  ");
        }
        System.Console.WriteLine();
    }
}

int[,] ReverceArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j > i)
            {
                temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
    }
    return array;
}*/