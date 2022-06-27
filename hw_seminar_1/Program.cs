int current;
int N;
Console.Write("Введите число : ");
N = Convert.ToInt32(Console.ReadLine());
current = 2;
while (current<=N)
{
Console.Write(current+" ");
current = current+2;
}

if (N < 2)
{
    Console.Write("Введите число не меньше 2: ");

}