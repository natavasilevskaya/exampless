int a = 1;
int b = 21;
int c = 123;
int d = 66;
int e = 99;

int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;
if (d>max) max = d;
if (e>max) max = e;

Console.Write("max = ");
Console.WriteLine(max);