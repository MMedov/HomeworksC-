//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
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

int[,] SortRowsFromMinToMax(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {   int x=array.GetLength(1)-1; 
        while(x>0) 
        { 
            for(int j=0; j<array.GetLength(1)-1; j++)
            {   
                
                if (array[i,j] > array[i,j + 1])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                }
            }
        x--;
        }
    }
    return array;
}

int min = 0;
int max = 9;
int m = new Random().Next(4, 9); //Пусть массив будет рандомного размера, без запросов к пользователю
int n = new Random().Next(4, 9);
int[,] arr = Create2dArray(m, n, min, max);
ShowArray(arr);
SortRowsFromMinToMax(arr);
Console.WriteLine();
ShowArray(SortRowsFromMinToMax(arr));
*/


//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
/*
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
int MinSumRow(int[,] array)
{
    int minRowSum = int.MaxValue;
    int indexMinRow = 0;
    
    for(int i=0; i<array.GetLength(0); i++)
    {
        int rowSum = 0;
        for(int j=0; j<array.GetLength(1); j++)
        {
            rowSum += array[i,j];
        }
        if(rowSum<minRowSum)
        {
            minRowSum = rowSum;
            indexMinRow=i; 
        }
        
    }

    return indexMinRow+1;
}

int min = 0;
int max = 9;
int m = new Random().Next(3, 5); //Пусть массив будет рандомного размера, без запросов к пользователю
int n = new Random().Next(3, 5);
int[,] arr = Create2dArray(m, n, min, max);

ShowArray(arr);
Console.WriteLine(MinSumRow(arr));
*/

//Заполните спирально массив 4 на 4
