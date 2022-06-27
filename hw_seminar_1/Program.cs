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
