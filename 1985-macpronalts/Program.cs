// https://www.beecrowd.com.br/judge/pt/problems/view/1985
int qtd = int.Parse(Console.ReadLine());

double total = 0.0;

for (int i = 0; i < qtd; i++)
{
    string[] entradas = Console.ReadLine().Split(' ');
    total += BuscarValor(int.Parse(entradas[0]), int.Parse(entradas[1]));
}

Console.WriteLine($"{total:F2}");

static double BuscarValor(int id, int qtd)
{
    if (id == 1001)
    {
        return 1.50 * qtd;
    }
    else if (id == 1002)
    {
        return 2.50 * qtd;
    }
    else if (id == 1003)
    {
        return 3.50 * qtd;
    }
    else if (id == 1004)
    {
        return 4.50 * qtd;
    }
    else if (id == 1005)
    {
        return 5.50 * qtd;
    }
    else
    {
        return 0;
    }
}