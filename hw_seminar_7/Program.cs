//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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

int min = 1;
int max = 10;
Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = Create2dArray(m, n, min, max);
ShowArray(arr);