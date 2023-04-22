// https://www.beecrowd.com.br/judge/pt/problems/view/1180
int N = int.Parse(Console.ReadLine());
int[] X = new int[N];
string[] valores = Console.ReadLine().Split(' ');

// 1 2 3 4 -5 6 7 8 9 10
for (int i = 0; i < X.Length; i++)
{
    X[i] = int.Parse(valores[i]);
}

int menorValor = X[0], posMenorValor = 0;

if (X.Length > 0)
{
    for (int i = 0; i < X.Length; i++)
    {
        if (X[i] < menorValor)
        {
            menorValor = X[i];
            posMenorValor = i;
        }
    }
}

Console.WriteLine($"Menor valor: {menorValor}");
Console.WriteLine($"Posicao: {posMenorValor}");