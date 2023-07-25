int n  =  int.Parse(Console.ReadLine());
int[] b = { 100, 20, 10, 5, 1};
int c = 0;
for (int i = 0; i < b.Length; i++)
{
    c += n / b[i];
    n %= b[i];
}
Console.WriteLine(c);