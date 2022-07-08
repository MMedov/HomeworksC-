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
int[] CreateRandomArray(int size, int min, int max) 
{ 
    int[] array = new int[size];  
 
    for(int i = 0; i < size; i++) 
    array[i] = new Random().Next(min, max); 
    return array; 
} 
int CountOfEvens(int[] array)
 {  int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;  
    }

    return count;
 }
void ShowArray(int[] array) 
{ 
    for(int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 

int size = new Random().Next(10, 20);
int min = 100;
int max = 999;
int[] arr = CreateRandomArray(size, min, max); 
ShowArray(arr);
Console.Write(CountOfEvens(arr));
