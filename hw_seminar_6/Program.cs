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




//Найти точку пересечения заданных прямых
void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1-b2)/(k2-k1);
    double y = (k2*b1-k1*b2)/(k2-k1);
    if(k1==k2) Console.Write("Заданные прямые не пересекаются!");
    else
    Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}

Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
CrossPoint(k1,b1,k2,b2);