var dictionary = new Dictionary<int, int>();
var array = GetArray(4, 4);

ShowArray(array);

foreach (var item in array)
{
	if (dictionary.ContainsKey(item))
	{
		dictionary[item]++;
	}
	else
	{
		dictionary.Add(item, 1);
	}
}

foreach (var item in dictionary.OrderBy(x => x.Key))
{
	Console.WriteLine($"{item.Key} --- {item.Value}");
}



int[,] GetArray(int length1, int length2)
{
	int[,] array = new int[length1, length2];

	for (int i = 0; i < length1; i++)
	{
		for (int j = 0; j < length2; j++)
		{
			array[i, j] = new Random().Next(0, 11);
		}
	}

	return array;
}

void ShowArray(int[,] array)
{

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j]);
		}
		Console.WriteLine();
	}
}
