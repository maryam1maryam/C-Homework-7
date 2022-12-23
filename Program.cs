// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


/*double[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    var array = new double[rowLength, colLength];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRange, maxRange + 1) + rnd.NextDouble();

        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("{0,6:F1}", array[i, j]);
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


double[,] array = GenerateArray(3, 4, -10, 10);
PrintArray(array);*/





// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*int[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    var array = new int[rowLength, colLength];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRange, maxRange + 1);
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
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintSearchValue(int[,] array, int[] position)
{
    if (position[0] <= array.GetLength(0) && position[1] <= array.GetLength(1))
    {
        System.Console.WriteLine($"{array[position[0]-1, position[1]-1]}");
    }
    else
    {
    System.Console.WriteLine($"Такого элемента нет");
    }
}

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение невозможно преобразовать в число");
}

int[,] array = GenerateArray(3, 4, 0, 100);
PrintArray(array);
int[] position = new int[2];
for (int i = 0; i < position.Length; i++)
{
    position[i] = Prompt($"Введите позицию {i+1} искомого элемента (1-строка, 2-столбец) -> ");
}
System.Console.WriteLine($"{position[0]}, {position[1]}");
PrintSearchValue(array, position);*/



// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*double[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    var array = new double[rowLength, colLength];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRange, maxRange + 1);

        }
    }
    return array;
}

void PrintArrayMAtrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double[] AverageSumOfColumn(double[,] array)
{
    double[] ave = new double[array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        ave[k] = sum / array.GetLength(0);
        k++;
    }
    return ave;
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write("{0,6:F1}", item);
    }
    System.Console.WriteLine();
}

double[,] array = GenerateArray(3, 4, 0, 10);
PrintArrayMAtrix(array);
double[] ave = AverageSumOfColumn(array);
PrintArray(ave);*/