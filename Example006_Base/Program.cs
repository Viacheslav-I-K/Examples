int a = new Random().Next(1, 100);
Console.Write("Вес первой гири = ");
Console.WriteLine(a);
int b = new Random().Next(1, 100);
Console.Write("Вес первой гири = ");
Console.WriteLine(b);
int c = new Random().Next(1, 100);
Console.Write("Вес первой гири = ");
Console.WriteLine(c);
int d = new Random().Next(1, 100);
Console.Write("Вес первой гири = ");
Console.WriteLine(d);
int e = new Random().Next(1, 100);
Console.Write("Вес первой гири = ");
Console.WriteLine(e);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);