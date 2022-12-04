Console.Clear();
Console.WriteLine("Enter first numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second numbers: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third numbers: ");
int c = Convert.ToInt32(Console.ReadLine());
int max =0;
Console.Clear();

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"Max number: {max}");

