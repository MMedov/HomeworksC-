/*
Console.WriteLine("Hello, World!");
int[] five = {1, 6, 3, 0, 8};
void FromMaxToMin(int[] array)
{
    
    for(int i=0; i<array.Length; i++)
    {
        int Maximum = i;
        for(int j=i+1; j<array.Length; j++)
        {
            if(array[j]>array[Maximum])
            Maximum = j;
        }
        int temp = array[i];
        array[i] = array[Maximum];
        array[j] = temp;
        
    }
}

void FromMaxToMin(int[] array)
*/



























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