int a = int.Parse(Console.ReadLine());
int[] arr = new int[a];

int c = 1;
for (int i = 0; i < a; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
for(int i = 0; i < a-1; i++)
{
    if (arr[i] != arr[i + 1])
    {
        c++;
    }
}
Console.WriteLine(c);