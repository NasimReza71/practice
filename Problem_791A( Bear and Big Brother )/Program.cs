string[] i = Console.ReadLine().Split();
int a = int.Parse(i[0]);
int b = int.Parse(i[1]);
int c = 0;
while (a <= b)
{
    a = a * 3;
    b = b * 2;
    c++;
}

Console.WriteLine(c);