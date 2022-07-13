//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i<size; i++)
    {
        Console.Write($"Input {i+1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array) 
{ 
    for(int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 
int PositiveCount(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i] > 0) count +=1;
    }
    return count;
}

Console.WriteLine("Сколько чисел будем проверять? ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(M);
ShowArray(arr);
Console.WriteLine($"Вы ввели {PositiveCount(arr)} чисел больше нуля!");
*/



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
