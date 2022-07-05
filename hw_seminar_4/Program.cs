
 //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int num)
{  
    int sum = 0;
    while(num>0)
    {
        sum = sum + (num%10);
        num = num/10;
    }
    return sum;
}

Console.Write("Сумма цифр введеного числа равна " + SumOfDigits(N));
*/

//Напишите программу, которая задаёт массив из m элементов и выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]


Console.Write("Массив из сколько элементов вам нужен? Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int[m];
Random rnd = new Random();

void MassiveOfRandom(int x)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
        Console.Write($"{array[i]} ");
    }
}



MassiveOfRandom(m);