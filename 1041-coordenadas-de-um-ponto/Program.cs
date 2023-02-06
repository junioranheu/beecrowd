// https://www.beecrowd.com.br/judge/pt/problems/view/1041
string[] valores = Console.ReadLine().Split(' ');

double x = double.Parse(valores[0]);
double y = double.Parse(valores[1]);

if (x == 0 && y == 0)
{
    Console.WriteLine("Origem");
}
else if (x == 0 && y != 0)
{
    Console.WriteLine("Eixo Y");
}
else if (y == 0 && x != 0)
{
    Console.WriteLine("Eixo X");
}
else
{
    int trunc = (int)Math.Truncate(x);
    trunc = (trunc < 1) ? 1 : trunc;

    Console.WriteLine($"Q{trunc}");
}