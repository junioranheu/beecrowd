// https://www.beecrowd.com.br/judge/pt/problems/view/1929
string[] entrada = Console.ReadLine().Split(' ');
int A = int.Parse(entrada[0]);
int B = int.Parse(entrada[1]);
int C = int.Parse(entrada[2]);
int D = int.Parse(entrada[3]);

if (A < B + C && B < A + C && C < A + B)
{
    Console.WriteLine("S");
}
else if (A < B + D && B < A + D && D < A + B)
{
    Console.WriteLine("S");
}
else if (A < C + D && C < A + D && D < A + C)
{
    Console.WriteLine("S");
}
else if (B < C + D && C < B + D && D < B + C)
{
    Console.WriteLine("S");
}
else
{
    Console.WriteLine("N");
}