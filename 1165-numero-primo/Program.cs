// https://www.beecrowd.com.br/judge/pt/problems/view/1165
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    int X = int.Parse(Console.ReadLine());

    int qtdDivisiveis = 0;

    for (int j = 1; j <= X; j++)
    {
        if (X % j == 0)
        {
            qtdDivisiveis++;
        }
    }

    bool isPrimo = qtdDivisiveis == 2;

    if (isPrimo)
    {
        Console.WriteLine($"{X} eh primo");
    }
    else
    {
        Console.WriteLine($"{X} nao eh primo");
    }
}