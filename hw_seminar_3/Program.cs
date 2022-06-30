//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void Cube(int x)
{
    int current = 1;
    while(current <= x )
    {
        int quad = current * current * current;
        Console.Write(quad + " ");
        current++;
    }
}

if(N < 1) 
    Console.Write("Введенное число меньше 1!");
else
    Cube(N);
*/


//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Is5Palindrom(int x)
{
    int first = x / 10000;
    int fifth = x % 10;
    int centre3 = (x % 10000) / 10;
    int second = centre3 / 100;
    int forth = centre3 % 10;
    if(first == fifth && second == forth) Console.WriteLine("Палиндром!");
    else Console.WriteLine("Не палиндром!");
}


Console.Write("Введите число пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N<10000 || N>99999) Console.Write("Введенное число не пятизначное! ");
else
Is5Palindrom(N);
*/
