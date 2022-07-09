/*
Console.Write("Input min possible value of elements: "); 
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input max possible value of elements: "); 
int max = Convert.ToInt32(Console.ReadLine()); 
void ShowArray(int[] array) 
{ 
    for(int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 

 */
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int min, int max) 
{ 
    int[] array = new int[size];  
 
    for(int i = 0; i < size; i++) 
    array[i] = new Random().Next(min, max); 
    return array; 
} 
void ShowArray(int[] array) 
{ 
    for(int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 
int CountOfEvens(int[] array)
 {  int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;  
    }

    return count;
 }

int size = new Random().Next(10, 15);//размер массива будет рандомным
int min = 100;
int max = 999;
int[] arr = CreateRandomArray(size, min, max); 
ShowArray(arr);
Console.Write(CountOfEvens(arr));
*/
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int min, int max) 
{ 
    int[] array = new int[size];  
 
    for(int i = 0; i < size; i++) 
    array[i] = new Random().Next(min, max); 
    return array; 
} 
void ShowArray(int[] array) 
{ 
    for(int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 
int SumOfOddPositions(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2) sum = sum + array[i];
    return sum;
}

int size = new Random().Next(10, 15); //размер массива будет рандомным
int min = 0;
int max = 9;
int[] arr = CreateRandomArray(size, min, max); 
ShowArray(arr);
Console.Write(SumOfOddPositions(arr));
*/
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//(тут я не совсем понял какие числа должны быть, поэтому написал метод создающий массив с  рандомными ...
//... числами от min до max с двумя цифрами после запятой. Сам метод принимает диапазон в виде min, max и size из основной программы)
double[] CreateRandomArray(int size, int min, int max) 
{ 
    double[] array = new double[size];  
 
    for(int i = 0; i < size; i++) 
    {
        array[i] = new Random().NextDouble() * (max-min) + min;
        array[i] = Math.Round(array[i], 2);
    }
    
    return array; 
} 
void ShowArray(double[] array) 
{ 
    for(int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 
double MaxMinDifference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i=1; i<array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    return Math.Round(max-min, 2);//без округления иногда выдавались значения с кучей цифр после запятой, несмотря на то, что в массиве таких чисел нет
}

int size = new Random().Next(10, 15); //размер массива будет рандомным
int min = 1;
int max = 10;
double[] arr = CreateRandomArray(size, min, max); 
ShowArray(arr);
Console.Write(MaxMinDifference(arr));
//все работает как я задумал, а вот правильно ли я понял задачу это вопрос)