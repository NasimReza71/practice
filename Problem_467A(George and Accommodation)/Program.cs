int n  = int.Parse(Console.ReadLine());
int c = 0;
for (int i = 0; i < n; i++)
{
    string[] inputs = Console.ReadLine().Split(' ');
    int a = int.Parse(inputs[0]);
    int b = int.Parse(inputs[1]);

    if (b - a >= 2)
    {
        c++;
    }
}
Console.WriteLine(c);