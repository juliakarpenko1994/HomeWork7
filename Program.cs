/*Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

double [,] GenerateintArray(int rows, int colums)
{
    double[,] array = new double[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]:f2}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
double[,] newArray = GenerateintArray(3, 4);
PrintArray(newArray); */

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет

int Promt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[,] GenerateArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

(int, bool) FindElement(int[,] array, int row, int colum)
{
    if (0 <= row && row < array.GetLength(0)
    && colum >= 0 && colum < array.GetLength(1))
    {
        return (array[row, colum], true);
    }
    else
    {
        return (0, false);
    }
}

int[,] newArray = GenerateArray(3, 4);
PrintArray(newArray);
int rowNumber = Promt("Введите номер строки:");
int columNumber = Promt("Введите номер столбца:");
(int result, bool isExisted) = FindElement(newArray, rowNumber, columNumber);
if (isExisted)
{
    System.Console.WriteLine($"Элемент массива ({rowNumber}, {columNumber}) -> {result} ");
}
else
{
    System.Console.WriteLine("Такого элемента нет в массиве");
}*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
 в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] GenerateArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double[] ArithmeticMeanOnColums(int[,] array)
{
    double sum = 0;
    double[] arithMeanColums = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        arithMeanColums[i] = sum / array.GetLength(0);
        sum = 0;
    }
    return arithMeanColums;
}
void PrintArithmeticMeanArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"{arr[i]:2}/t");
    }
    System.Console.WriteLine();
}
int[,] newArray = GenerateArray(3, 4);
PrintArray(newArray);
double[] resultArray = ArithmeticMeanOnColums(newArray);
System.Console.WriteLine("Среднее арифметическое в каждом столбце массива: ");
PrintArithmeticMeanArray(resultArray);*/