// https://www.beecrowd.com.br/judge/pt/problems/view/1072
int N = int.Parse(Console.ReadLine());

int qtdIn = 0;
int qtdOut = 0;

for (int i = 0; i < N; i++)
{
    int X = int.Parse(Console.ReadLine());

    if (X >= 10 && X <= 20)
    {
        qtdIn++;
    }
    else
    {
        qtdOut++;
    }
}

Console.WriteLine($"{qtdIn} in");
Console.WriteLine($"{qtdOut} out");