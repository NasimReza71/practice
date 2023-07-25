int n, a,b,c, number = 0; 
n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
 
 string[] inputs = Console.ReadLine().Split(' ');
 a = int.Parse(inputs[0]);
 b = int.Parse(inputs[1]);
 c = int.Parse(inputs[2]);

 if (a + b + c >= 2)
   {
      number++;
   } 
}
 Console.WriteLine(number);
        
    







