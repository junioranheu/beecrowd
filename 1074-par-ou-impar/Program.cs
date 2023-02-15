// https://www.beecrowd.com.br/judge/pt/problems/view/1074
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    int X = int.Parse(Console.ReadLine());
    Console.WriteLine(GerarResposta(X));
}

static string GerarResposta(int X)
{
    if (X == 0 )
    {
        return "NULL";
    }

    string evenOdd = X % 2 == 0 ? "EVEN" : "ODD";
    string positiveNegative = X > 0 ? "POSITIVE" : "NEGATIVE";

    return $"{evenOdd} {positiveNegative}";
}