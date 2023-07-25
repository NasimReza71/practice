int n  = int.Parse(Console.ReadLine());
int sum = 0, k = 0;
for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    int s1 = int.Parse(s[0]);
    int s2 = int.Parse(s[1]);
    sum = (s1 + k) - s2;
    if (sum < 0)
    {
        k = 0;
    }
    else
    {
        k = sum;
    } 
}
Console.WriteLine(sum);

