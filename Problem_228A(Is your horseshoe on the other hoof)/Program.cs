int s, s1, s2, s3, c = 1, r = 0;
string[] inputs = Console.ReadLine().Split(' ');
s = int.Parse(inputs[0]);
s1 = int.Parse(inputs[1]);
s2 = int.Parse(inputs[2]);
s3 = int.Parse(inputs[3]);

if (s != s1 && s != s2 && s != s3)
{
    c++;
}
if (s1 != s2 && s1 != s3)
{
    c++;
}
if (s2 != s3)
{
    c++;
}

r = 4 - c;
Console.WriteLine(r);