// Крестики нолики

string[,] matrix = new string[3,3];



void FillArray(string[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = " - ";
        }
        System.Console.WriteLine();
    }
}

void PrintArray(string[,]matrix)
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

/*int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}*/


void XO()
{
for (int i = 0; i < 9; i++)
{
    System.Console.WriteLine("ваша сторона ? введите Х/0");
    switch (Console.ReadLine)
    {
        
        default:
    }
}
}

FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();



/*void PrintImage(int [,] image)
{
for (int i = 0; i < image.GetLength(0); i++)   
    {
    for (int j = 0; j < image.GetLength(1); j++)   
       { //System.Console.Write($"{matrix[i,j]} "); 
        if(image[i,j] == 0) System.Console.Write($" "); 
        else System.Console.Write($"O");
       }
       System.Console.WriteLine();
    }
}*/