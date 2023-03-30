// https://www.beecrowd.com.br/judge/pt/problems/view/1132
int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());

if (X > Y)
{
    int jar = X;
    X = Y;
    Y = jar;
}

int somaTotal = 0;

for (int i = X; i <= Y; i++)
{
    if (i % 13 > 0)
    {
        somaTotal += i;
    }
}

Console.WriteLine(somaTotal);