// See https://aka.ms/new-console-template for more information

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

