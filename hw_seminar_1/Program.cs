//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 2;

if (N < 2)
{
    Console.Write("Введите число не меньше 2: ");

}

while (current<=N)
{
Console.Write(current+" ");
current = current+2;
}



 //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.Write("Первое число больше второго!");
}
if(a<b)
{
    Console.Write("Второе число больше первого!");
}
if(a==b)
{
    Console.Write("Числа равны!");
}
*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число : ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b>max)
{
    max = b;
}
if(c>max)
{
    max = c;
}
Console.WriteLine("Максимальное число: " + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
if (N%2 == 0)
{
    Console.WriteLine("Число " + N + " является четным!");
}
else 
{
    Console.WriteLine("Число " + N + " является нечетным!");
}
*/