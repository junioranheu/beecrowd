// https://www.beecrowd.com.br/judge/pt/problems/view/1064
const int qtdLoops = 6;
int qtdValoresPositivos = 0;
double mediaValoresPositivos = 0;

for (int i = 0; i < qtdLoops; i++)
{
    double valor = double.Parse(Console.ReadLine());

    if (valor > 0)
    {
        qtdValoresPositivos += 1;
        mediaValoresPositivos += valor;
    }
}

Console.WriteLine($"{qtdValoresPositivos} valores positivos");
Console.WriteLine($"{(mediaValoresPositivos/ qtdValoresPositivos):F1}");