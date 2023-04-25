// https://www.beecrowd.com.br/judge/pt/problems/view/1858
int N = int.Parse(Console.ReadLine());
string[] valores = Console.ReadLine().Split(' ');

int pos = 0 + 1;
int menor = int.Parse(valores[0]);

for (int i = 0; i < N; i++)
{
    int valorAtual = int.Parse(valores[i]);

    if (menor > valorAtual)
    {
        menor = valorAtual;
        pos = i + 1;
    }
}

Console.WriteLine(pos);