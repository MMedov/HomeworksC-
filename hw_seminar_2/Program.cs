/*
Console.Write("Введите номер дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());

void IsItWeekend(int num)
{
    if(num == 6 || num == 7)
        Console.WriteLine("Да, это выходной!");
        
    else
        if(num < 1 || num > 7)
            Console.WriteLine("Я для тебя шутка какая-то?!");
        else
        Console.WriteLine("Нет, это не выходной!");
}

IsItWeekend(x);
*/




//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

int SecondNumber(int num)
{
    int num2 = num / 10;
    int result = num2 % 10;
    return result;
}

if(x <100 || x > 999)
    Console.Write("Введенное число не трехзначное!");
else
    Console.WriteLine(SecondNumber(x));


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет