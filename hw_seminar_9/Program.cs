/*Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

int DigitsCount(int N)
{
    if(N>9)
    {
        
        return 1 + DigitsCount(N/10);
    }
   else
    return 1;
}


Console.WriteLine(DigitsCount(230043));
*/
//Задача 66: Задайте значения M и N. .


int SumOfRange(int M, int N)
{
    if(M<N)
    {
        return M + SumOfRange(M+1, N);
    }
    else
        return M;
}   

Console.WriteLine(SumOfRange(3, 8));