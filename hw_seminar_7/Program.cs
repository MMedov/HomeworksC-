//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] Create2dArray(int rows, int columns, int min, int max)
{
 double[,] array = new double[rows, columns];
 for(int i=0; i<array.GetLength(0); i++)
 {
    for(int j=0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random().NextDouble() * (max-min) + min;
        array[i,j] = Math.Round(array[i,j], 2);
    }
 }
 return array;
}
void ShowArray(double[,] array) 
{ 
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
        
} 

int min = -10;
int max = 10;
Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = Create2dArray(m, n, min, max);
ShowArray(arr);
*/

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] Create2dArray(int rows, int columns, int min, int max)
{
 int[,] array = new int[rows, columns];
 for(int i=0; i<array.GetLength(0); i++)
 {
    for(int j=0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(min, max);
    }
 }
 return array;
}
void ShowArray(int[,] array) 
{ 
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
        
} 
void AverageOfColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
            sum = Math.Round(sum/array.GetLength(0),1);
        Console.Write($"{sum} ");
    }
        
}
int min = 0;
int max = 10;
Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = Create2dArray(m, n, min, max);
ShowArray(arr);
Console.WriteLine();
AverageOfColumns(arr);
