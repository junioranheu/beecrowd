// https://www.beecrowd.com.br/judge/pt/problems/view/1094
int N = int.Parse(Console.ReadLine());

int totalCoelhos = 0;
int totalRatos = 0;
int totalSapos = 0;

for (int i = 0; i < N; i++)
{
    string[] respostas = Console.ReadLine().Split(' ');
    int Quantia = int.Parse(respostas[0]);
    string Tipo = respostas[1];

    var results = SomarPorTipo(totalCoelhos, totalRatos, totalSapos, Quantia, (Tipo ?? string.Empty));
    totalCoelhos = results.Item1;
    totalRatos = results.Item2;
    totalSapos = results.Item3;
}

int totalCobaias = SomarCobaias(totalCoelhos, totalRatos, totalSapos);

Console.WriteLine($"Total: {totalCobaias} cobaias");
Console.WriteLine($"Total de coelhos: {totalCoelhos}");
Console.WriteLine($"Total de ratos: {totalRatos}");
Console.WriteLine($"Total de sapos: {totalSapos}");
Console.WriteLine($"Percentual de coelhos: {((Convert.ToDouble(totalCoelhos) / totalCobaias) * 100):F2} %");
Console.WriteLine($"Percentual de ratos: {((Convert.ToDouble(totalRatos) / totalCobaias) * 100):F2} %");
Console.WriteLine($"Percentual de sapos: {((Convert.ToDouble(totalSapos) / totalCobaias) * 100):F2} %");

static Tuple<int, int, int> SomarPorTipo(int totalCoelhos, int totalRatos, int totalSapos, int qtd, string tipo)
{
    if (tipo.ToUpper() == "C")
    {
        totalCoelhos += qtd;
    }
    else if (tipo.ToUpper() == "R")
    {
        totalRatos += qtd;
    }
    else if (tipo.ToUpper() == "S")
    {
        totalSapos += qtd;
    }

    return Tuple.Create(totalCoelhos, totalRatos, totalSapos);
}

static int SomarCobaias(int totalCoelhos, int totalRatos, int totalSapos)
{
    return totalCoelhos + totalRatos + totalSapos;
}