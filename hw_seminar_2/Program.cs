Console.Write("Введите день недели: ");
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